using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Abstract
{
    //interface'lerin default metot erişim belirleyicileri nedir.
    public interface IYakinlastir
    {
        public bool DurbunluMu { get; set; }
        string Yakinlastir();
        string Uzaklastir();
    }
}
