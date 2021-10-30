using Entities.Interfaces;
using Entities.POCO;
using Moq;
using NUnit.Framework;
using Repositories.EntityFrameworkCore.Repositories;
using System.Collections.Generic;

namespace CleanTesting
{
    public class Tests
    {

       
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();

            //ARRANGE
            List<Promocion> list = new List<Promocion>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Promocion { 
                    Id = 20 + i,
                    Nombre="cliente" + i,
                    Email="mailciente" + i,
                    Estado= "generado",
                    Codigo= "CODPRO00" + i,
                    FechaCreacion=System.DateTime.Now,
                    FechaCanje=null
                });
            }
            //ACT
            var mock = new Mock<IPromocionRepository>();

            mock.Setup(m => m.GetAll()).Returns(list);
            //ASSERT
            int expected = 20;
            foreach (var i in mock.Object.GetAll())
            {
                Assert.AreEqual(expected++, i.Id);
            }

        }
    }
}