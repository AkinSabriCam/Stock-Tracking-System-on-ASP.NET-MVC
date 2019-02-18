using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StokYonetimSistemi.Models;
namespace StokYonetimSistemi.ViewModels
{
    public class KullaniciRole
    {
        public tblKullanıcı Kullanici { get; set; }
        public List<tblRole> Roller;
    }
}