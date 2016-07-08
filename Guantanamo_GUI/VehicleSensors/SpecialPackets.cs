using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI.VehicleSensors
{
    public struct PMTK_ResponseStruct
    {
        public List<string> Params;
        public string CommandNumber;
        public string CommandLine;

        public PMTK_ResponseStruct(string commandLine)
        {
            CommandLine = commandLine;
            Params = new List<string>();
            CommandNumber = "";
            DecodePMTKResponse(commandLine);
        }

        public void DecodePMTKResponse(string line)
        {
            string[] split = line.Split('*');
            string command = split[0];
            command = command.Remove(0, 5); //remove $PMTK
            string[] paramsSplit = command.Split(',');
            CommandNumber = paramsSplit[0];

            for (int i = 1; i < paramsSplit.Length; i++)
            {
                Params.Add(paramsSplit[i]);
            }
        }
    }

    public struct AcknowledgePacketStruct
    {
        public string CommandNumber;
        public DateTime TimeStamp;

        public AcknowledgePacketStruct(string command)
        {
            CommandNumber = command;
            TimeStamp = DateTime.UtcNow;
        }
    }



    class SpecialPackets : Sensor
    {
        public PMTK_ResponseStruct PMTK_Response { get; set; }
        public string NMEA_Sentence { get; set; }
        public AcknowledgePacketStruct AcknowledgePacket { get; set; }

        public volatile bool AcknowledgeFlag = false;

        public SpecialPackets()
        {
            Designator = "$PMTK,$G,~";
        }

        public override bool CheckDesignator(string lineDesi)
        {
            string[] desis = Designator.Split(',');
            foreach (string desi in desis)
            {
                if (lineDesi.Contains(desi)) { return true; }
            }

            return false;
        }

        public override bool Update(string[] split)
        {
            string designator = split[0];

            if (designator.Contains("$PMTK"))
            {
                pmtkResponse(reconstructLine(split));
                return true;
            }

            if (designator.Contains("$G"))
            {
                NMEA_Sentence = reconstructLine(split);
                return true;
            }

            if (designator.Contains("~"))
            {
                acknowledgement(reconstructLine(split));
                return true;
            }

            return false;
        }

        void pmtkResponse(string data)
        {
            PMTK_Response = new PMTK_ResponseStruct(data);
        }

        void acknowledgement(string line)
        {
            AcknowledgePacketStruct aP = new AcknowledgePacketStruct("-1");

            AcknowledgePacket = new AcknowledgePacketStruct(line.Replace("~",""));
            AcknowledgeFlag = true;
        }

        string reconstructLine(string[] split)
        {
            if (split.Length == 0) { return ""; }

            string line = "";

            for (int i = 0; i != split.Length - 1; i++)
            {
                line += split[i] + ",";
            }

            line += split[split.Length - 1];

            return line;
        }
    }
}
