using System.Collections.Generic;
using System.Text.Json;
using DataAccess.Persistence;
using Entitiy;
using NUnit.Framework;

namespace DataAccess.Test
{
    
    [TestFixture]
    public class QueryTest
    {
        protected FamilyContext ctx;

        [SetUp]
        public virtual void Setup()
        {
            ctx = new FamilyContext();
        }
        
        /*[Test]
        public virtual void CreateAndSeed()
        {
            IList<Family> families = new FamilyGenerator().GenerateFamilies(500);
            string famSerialized = JsonSerializer.Serialize(families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            DBSeeder.Seed(families);
        }*/

        [Test]
        public void AddNewAdult(string streetName, int houseNum, Adult adult)
        {
            
        }
        
        
        
        
    }
}