using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Sto1
{
    internal class StoOdin
    {

        private int Round { get; set; }
        private Properties.Settings properties;
        private StringCollection parameters;
        public int Bank;
        private List<Otvet> otvety;
        public string Vopros;
        public StoOdin(int round)
        {
            parameters = new StringCollection();
            Round = round;
        }

        public void Init()
        {
            Vopros = "";
            Bank = 0;
            properties = Sto1.Properties.Settings.Default;
            switch (Round)
            {
                case 1:
                    parameters = properties.Round1;
                    otvety = Parsing(parameters);
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
            
        }

        private List<Otvet> Parsing(StringCollection parameters)
        {
            List<Otvet> otvets = new List<Otvet>();
            for (var i=0;i<parameters.Count;i++)
            {
                Vopros = parameters[0];
                if (i > 0)
                {
                    Otvet otvet = new Otvet();
                    otvet.nomer = i;
                    string[] arr = parameters[i].Split('=');
                    otvet.text = arr[0];
                    otvet.ochki = Convert.ToInt32(arr[1]);
                    otvet.pass = false;
                    otvets.Add(otvet);
                }
            }
            return otvets;
        }

        internal string[] OtvetVerny(int v1)
        {
            string[] display = new string[3];
            Otvet otvet = otvety[v1 - 1];
            if (!otvet.pass)
            {
                Bank += otvet.ochki;
                otvet.pass = true;
                display[0] = otvet.nomer.ToString();
                display[1] = otvet.text;
                display[2] = otvet.ochki.ToString();
                return display;
            }
            else
            {
                Bank -= otvet.ochki;
                otvet.pass = false;
                display[0] = "";
                display[1] = otvet.nomer.ToString();
                display[2] = "";
                return display;
            }
        }

        private class Otvet
        {
            public int nomer { get; set;}
            public string text { get; set; }
            public int ochki { get; set; }

            public bool pass { get; set; }
        }
    }
}