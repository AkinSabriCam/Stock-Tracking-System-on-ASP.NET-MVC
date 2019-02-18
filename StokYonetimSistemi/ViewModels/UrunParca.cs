using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StokYonetimSistemi.Models;
namespace StokYonetimSistemi.ViewModels
{
    public class UrunParca 
    {
        public tblUrunGenel Urun { get; set;}
        public List<tblParcaTipi> ParcaTipleri;
    }
}