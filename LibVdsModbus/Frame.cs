﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibVdsModbus
{
    public class Frame
    {
        
        private readonly ushort[] bytes;

        public Frame(ushort[] data)
        {
            if (data == null || data.Length < 12)
            {
                throw new ArgumentException();
            }

            this.bytes = data;
        }
        
        public bool Verbindungsaufbau_UE
        {
            get
            {
                return Convert.ToBoolean(this.bytes[0]);
            }
        }

        public bool Uebertragungsart
        {
            get
            {
                return Convert.ToBoolean(this.bytes[1]);
            }
        }

        public ushort Zyklus_Testmeldung
        {
            get
            {
                return this.bytes[2];
            }
        }


        public bool Allg_Meldung
        {
            get
            {
                return Convert.ToBoolean(this.bytes[3]);
            }
        }

        public bool Stoerung_Batterie
        {
            get
            {
                return Convert.ToBoolean(this.bytes[4]);
            }
        }

        public bool Erdschluss
        {
            get
            {
                return Convert.ToBoolean(this.bytes[5]);
            }
        }

        public bool Systemstoerung
        {
            get
            {
                return Convert.ToBoolean(this.bytes[6]);
            }
        }

        public bool Firmenspez_Meldung_Befehl_LS_AUS_VOM_NB
        {
            get
            {
                return Convert.ToBoolean(this.bytes[7]);
            }
        }

        public bool Firmenspez_Meldung_Stellung_LS
        {
            get
            {
                return Convert.ToBoolean(this.bytes[8]);
            }
        }

        public double Spannung
        {
            get
            {
                return Convert.ToDouble(this.bytes[9]);
            }
        }

        public double Strom
        {
            get
            {
                return Convert.ToDouble(this.bytes[10]);
            }
        }

        public double Leistung
        {
            get
            {
                return Convert.ToDouble(this.bytes[11]);
            }
        }

        public ushort Live_Signal
        {
            get
            {
                return this.bytes[12];
            }
        }

        public override string ToString()
        {
            return
                string.Format(
                    "Verbindungsaufbau UE: {0}, Übertragungsart: {1}, Zyklus Testmeldung: {2}, Allg. Meldung: {3}, Stoerung Batt: {4}, Erdschluss: {5}, Systemstoerung: {6}, FMBLSAUSVNB: {7}, FMBMSLS: {8}, Spannung: {9}, Strom: {10}, Leistung: {11}, LiveSig: {12}."
                    , this.Verbindungsaufbau_UE, this.Uebertragungsart, this.Zyklus_Testmeldung, this.Allg_Meldung, this.Stoerung_Batterie, this.Erdschluss, this.Systemstoerung, this.Firmenspez_Meldung_Befehl_LS_AUS_VOM_NB, this.Firmenspez_Meldung_Stellung_LS, this.Spannung, this.Strom, this.Leistung, this.Live_Signal);
        }
    }
}
