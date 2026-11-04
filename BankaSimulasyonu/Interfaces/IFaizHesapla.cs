using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSimulasyonu.Interfaces
{
    public interface IFaizHesapla
    {
        double FaizOranı { get; set; }
        double FaizHesapla();
        void FaizUygula();
    }
}