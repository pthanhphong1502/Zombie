using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_băn_Zombie
{
    class TaiKhoan
    {
        private string tentk;
        private string mk;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tentk, string mk)
        {
            this.tentk = tentk;
            this.mk = mk;
        }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Mk { get => mk; set => mk = value; }
    }
}
