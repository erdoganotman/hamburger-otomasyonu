using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class Entity
    {
        private int siparis_id;
        private string siparis_adı;
        private int siparis_ucreti;
        private int siparis_adeti;
        private int masano;

        public int Siparis_id { get => siparis_id; set => siparis_id = value; }
        public string Siparis_adı { get => siparis_adı; set => siparis_adı = value; }
        public int Siparis_ucreti { get => siparis_ucreti; set => siparis_ucreti = value; }
        public int Siparis_adeti { get => siparis_adeti; set => siparis_adeti = value; }
        public int Masano { get => masano; set => masano = value; }
    }
}
