using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Domain.Repositories;
using KWProjects.Moduls.GeoDB.Persistence.Context;
using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KWProjects.Moduls.GeoDB.Persistence.Test
{
    [TestClass]
    public class DatabaseConnection
    {

        private ContinentRepository continentRepository = null;

        [TestInitialize]
        public void Init()
        {
            continentRepository = new ContinentRepository();


        }

        [TestMethod]
        public void ConnectionTest()
        {
            Continent continent = new Continent();
            continent.Id = Guid.NewGuid();
            continent.Name = "Europa";
            continentRepository.Insert(continent);
            continentRepository.Commit();


            Continent result = continentRepository.Single(n => n.Name == "Europa");

            Assert.AreNotEqual(result.Name, string.Empty);

            continentRepository.Delete(result);
            continentRepository.Commit();


        }
    }
}
