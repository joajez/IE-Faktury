﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE_Faktury
{
    public class OsobaPrawna
    {
        private string nazwa;
        private string adres;
        private ulong nip;
        private ulong krs;
        private static uint liczbaTransakcji = 0;

        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public string Adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
            }
        }

        public ulong Nip
        {
            get
            {
                return nip;
            }

            set
            {
                nip = value;
            }
        }

        public ulong Krs
        {
            get
            {
                return krs;
            }

            set
            {
                krs = value;
            }
        }

        public uint LiczbaTransakcji
        {
            get
            {
                return liczbaTransakcji;
            }

            set
            {
                liczbaTransakcji = value;
            }
        }
    }
}
