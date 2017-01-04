using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        public string tenThamSo { get; set; }
        public int giaTri { get; set; }
        public ThamSo(string _tenThamSo, int _giaTri)
        {
            tenThamSo = _tenThamSo;
            giaTri = _giaTri;
        }
    }
}
