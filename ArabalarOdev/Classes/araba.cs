using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ArabalarOdev.Classes
{
    class araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapıSayısı { get; set; }
        public byte BeygirGucu { get; set; }
        public string ArabaTuru { get; set; }
        public int MaksımımHız { get; set; }
        public byte Cekis { get; set; }
        public int SıfırdanYuzeHızlanma { get; set; }
        public double Agırlık { get; set; }
        public double MotorHacmi { get; set; }

    }
}
