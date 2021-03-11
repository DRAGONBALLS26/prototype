using System;
using System.Collections.Generic;
using System.Text;

namespace prototype
{
    class Invitatie
    {
        public String Catre;
        public String Titlu;
        public String Continut;
        public String TrimisDe;
        public DateTime Data;
        public String p_Catre {
            get { return Catre; }
            set { Catre = value; }
        }
        public string p_Titlu
        {
            get { return Titlu; }
            set { Titlu = value; }
        }
        public string p_Continut {
            get { return Continut; }
            set { Continut = value; }
        }
        public string p_TrimisDe
        {
            get { return TrimisDe; }
            set { TrimisDe = value; }
        }
        public DateTime p_Data
        {
            get { return Data; }
            set { Data = value; }
        }
        public Invitatie CloneMe(Invitatie obj)
        {
            return (Invitatie)this.MemberwiseClone();
        }
    }
}

