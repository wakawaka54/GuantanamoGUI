using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.SensorModules;
using Guantanamo_GUI.UltilityModules;

namespace Guantanamo_GUI
{
    public class PresenterManager
    {
        public LogHandler LogHandler;

        public List<BaseSensorModule> SensorModules = new List<BaseSensorModule>();
        public List<UtilityBase> UtilityModules = new List<UtilityBase>();

        MDI_Parent _owner;

        volatile bool isUI_Updating = false;
        delegate void updateUI_Del(string line);
        updateUI_Del updateUI_Handler;

        public PresenterManager(MDI_Parent owner)
        {
            _owner = owner;

            VehicleSystems.Setup(this);

            updateUI_Handler = new updateUI_Del(UpdateUI);
            LogHandler = new LogHandler(this);
        }

        public void UpdateUI(string line)
        {
            #region INVOKE REQUIRED

            if (_owner.InvokeRequired)
            {
                isUI_Updating = true;
                _owner.BeginInvoke(updateUI_Handler, line);

                while (isUI_Updating) { } //lock background thread until UI is done updating

                return;
            }

            #endregion

            string[] split = line.Split(',');
            string designator = split[0]; //get only designator

            //update log
            LogHandler.Update(line);

            foreach (BaseSensorModule sensor in SensorModules)
            {
                if (sensor.IsDisposed && !sensor.CheckDesignator(designator)) { }
                else
                {
                    if (sensor.CheckDesignator(designator))
                    {
                        sensor.UpdateUI(line);
                    }
                }
            }


            foreach (UtilityBase utility in UtilityModules)
            {
                if (!utility.IsDisposed && !utility.CheckUpdate(designator)) { }
                else
                {
                    utility.UpdateUI(line);
                }
            }

            isUI_Updating = false;
        }

        public void ResetUI()
        {
            foreach (BaseSensorModule sensor in SensorModules)
            {
                sensor.ResetUI();
            }
        }

        public void AddUtilityUpdate(UtilityBase form)
        {
            UtilityModules.Add(form);
        }

        public void AddSensorModuleUpdate(BaseSensorModule form)
        {
            SensorModules.Add(form);
        }

        public void RemoveUtilityUpdate(UtilityBase form)
        {
            UtilityModules.Remove(form);
        }

        public void RemoveSensorModuleUpdate(BaseSensorModule form)
        {
            SensorModules.Remove(form);
        }

        public BaseSensorModule ReInit_Sensor(Sensor_Modules module)
        {
            BaseSensorModule match = null;

            foreach (BaseSensorModule sensor in SensorModules)
            {
                if (sensor.ModuleType == module) { match = sensor; break; }
            }

            if (match != null) { match.Close(); }

            BaseSensorModule m = BaseSensorModule.GetSensorModule_OfType(module, this);
            m.MdiParent = _owner;
            return m;

        }

        public UtilityBase ReInit_Utility(Utility_Modules module)
        {
            UtilityBase match = null;

            foreach (UtilityBase utility in UtilityModules)
            {
                if (utility.ModuleType == module) { match = utility; break; }
            }

            if (match != null) { match.Close(); }

            UtilityBase m = UtilityBase.GetUtility_OfType(module, this);
            m.MdiParent = _owner;
            return m;
        }

        public BaseSensorModule GetInit_Sensor(Sensor_Modules module)
        {
            foreach (BaseSensorModule sensor in SensorModules)
            {
                if (sensor.ModuleType == module) { sensor.Show(); return sensor; }
            }

            BaseSensorModule m = BaseSensorModule.GetSensorModule_OfType(module, this);
            m.MdiParent = _owner;
            return m;
        }

        public UtilityBase GetInit_Utility(Utility_Modules module)
        {
            foreach (UtilityBase utility in UtilityModules)
            {
                if (utility.ModuleType == module) { utility.Show(); return utility; }
            }
            UtilityBase m = UtilityBase.GetUtility_OfType(module, this);
            m.MdiParent = _owner;
            return m;
        }

        public void ShowWindow_Sensor(Sensor_Modules module)
        {
            BaseSensorModule m = GetInit_Sensor(module);
            m.Show();
        }

        public void ShowWindow_Utility(Utility_Modules module)
        {
            UtilityBase m = GetInit_Utility(module);
            m.Show();
        }
    }
}
