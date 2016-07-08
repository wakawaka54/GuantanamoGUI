using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.UltilityModules.DMP_Gains
{
    public partial class DMP_GainControl : UserControl
    {
        public Dictionary<int, double> Properties = new Dictionary<int, double>();

        public Dictionary<int, TextBox> Properties_GUI = new Dictionary<int, TextBox>();

        public DMP_GainControl()
        {
            InitializeComponent();
        }

        public virtual void UpdateProperty(string[] split)
        {
            int propertyCode = 0;

            if(!int.TryParse(split[2], out propertyCode)) { return; }

            if (Properties.Keys.Contains(propertyCode))
            {
                double value = 0;
                if (!double.TryParse(split[3], out value)) { return; }

                Properties[propertyCode] = value;
                Properties_GUI[propertyCode].Text = value.ToString();
            }
        }

        public virtual Dictionary<int, double> GetProperties()
        {
            try
            {
                foreach (int key in Properties_GUI.Keys)
                {
                    Properties[key] = Convert.ToDouble(Properties_GUI[key].Text);
                }
            }
            catch
            {
                MessageBox.Show("ERROR CONVERTING GAINS");
            }

            return Properties;
        }

        public virtual void ReadProperties()
        {
            writePropertiesToTextBox();
        }

        protected virtual void writePropertiesToTextBox()
        {
            foreach (int key in Properties.Keys)
            {
                Properties_GUI[key].Text = Properties[key].ToString("N5");
            }
        }
    }
}
