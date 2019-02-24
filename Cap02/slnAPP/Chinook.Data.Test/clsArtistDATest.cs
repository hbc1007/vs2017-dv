using System;
using System.Linq; //da.Gets() -- listado.Count()
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.Test
{
    [TestClass]
    public class clsArtistDATest
    {
        [TestMethod]
        public void GetCount()
        {
            var da = new clsArtistDA();
            var cantidad = da.GetCount();
            Assert.IsTrue(cantidad > 0);
        }

        [TestMethod]
        public void GetListado()
        {
            var da = new clsArtistDA();
            var listado = da.Gets();
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetWithParam()
        {
            var da = new clsArtistDA();
            var listado = da.GetWithParam("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void InsertArtist()
        {
            var da = new clsArtistDA();
            var id = da.InsertArtist(new clsArtist() {Name="Prueba"});
            Assert.IsTrue(id > 0);
        }
    }
}
