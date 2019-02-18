using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StokYonetimSistemi.ViewModels
{
    public class PersonelDepartman
    {
        public List<Models.tblDepartman> Departmanlar;
        public Models.tblPersonel Personel { get; set;}
    }
}