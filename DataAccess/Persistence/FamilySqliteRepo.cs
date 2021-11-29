using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class FamilySqliteRepo : IFamilyRepo
    {
        private FamilyContext fctx;

        public FamilySqliteRepo()
        {
            fctx = new FamilyContext();
        }

        public async Task<IList<Family>> getAllFamily(int? minAdultAge, int? maxAdultAge,
            bool? hasChild, bool? hasPet)
        {
            IQueryable<Family> families = fctx.Families.Include(f=>f.Adults).
                Include(f=>f.Pets).Include(f=>f.Children).ThenInclude(c=>c.Pets).AsQueryable();
            if (minAdultAge != null && maxAdultAge != null)
            {
              
                    families = families.Include(f=>f.Adults).
                        Include(f=>f.Pets).Include(f=>f.Children).ThenInclude(c=>c.Pets).Where(f => f.Adults.Any(adult =>
                    adult.Age >= minAdultAge && adult.Age <= maxAdultAge));
            }

            if (hasChild != null)
            {
                families =families.Include(f=>f.Adults).
                    Include(f=>f.Pets).Include(f=>f.Children).ThenInclude(c=>c.Pets).Where(f => f.Children.Any());
            }

            if (hasPet != null)
            {
                families = families.Include(f=>f.Adults).
                    Include(f=>f.Pets).Include(f=>f.Children).ThenInclude(c=>c.Pets).Where(f => f.Pets.Any());
            }

            return await families.ToListAsync();
        }

        public async Task<IList<Adult>> getAllAdult(string streetName, int houseNum)
        {
            
          //  Family family = await fctx.Families.FirstAsync(f => f.HouseNumber == houseNum && f.StreetName.Equals(streetName));
            var family = fctx.Families.Include(f => f.Adults).ToList()
                .Where(f => f.HouseNumber == houseNum && f.StreetName == streetName).FirstOrDefault();
            Console.WriteLine(family.Adults.Count);
            
            return family.Adults;
        }

        public async Task<IList<Child>> getAllChildren(string streetName, int houseNum)
        {
            var family = fctx.Families.Include(f => f.Children).ToList()
                .Where(f => f.HouseNumber == houseNum && f.StreetName == streetName).FirstOrDefault();
            Console.WriteLine(family.Adults.Count);
            
            return family.Children;
        }

        public async Task<IList<Pet>> getAllPets(string streetName, int houseNum)
        {
            var family = fctx.Families.Include(f => f.Pets).ToList()
                .Where(f => f.HouseNumber == houseNum && f.StreetName == streetName).FirstOrDefault();
            
            Console.WriteLine(family.Adults.Count);           
            return family.Pets;
        }


        public async Task AddNewAdult(string streetName, int houseNum, Adult adult)
        {
             Family family = await fctx.Families.FirstAsync(f => f.HouseNumber == houseNum && f.StreetName.Equals(streetName));
             family.Adults.Add(adult);
            await fctx.SaveChangesAsync();
        }

        public async Task AdNewChild(string streetName, int houseNum, Child child)
        {
            Family family = await fctx.Families.FirstAsync(f => f.HouseNumber == houseNum && f.StreetName.Equals(streetName));
            family.Children.Add(child);
            await fctx.SaveChangesAsync();

        }

        public async Task AddNewPet(string streetName, int houseNum, Pet pet)
        {
            Family family = await fctx.Families.FirstAsync(f => f.HouseNumber == houseNum && f.StreetName.Equals(streetName));
            family.Pets.Add(pet);
            await fctx.SaveChangesAsync();

        }

        public async Task AddNewChildPet(int childId, Pet pet)
        {

            Child child = await fctx.Families.SelectMany(f => f.Children).FirstAsync(c=> c.Id == childId);
                
            
            if(child != null) child.Pets.Add(pet);
            await fctx.SaveChangesAsync();


        }

        public async Task UpdateAdult(Adult adult)
        {
           Adult fAdult = await fctx.Families.SelectMany(f => f.Adults).FirstAsync(a => a.Id == adult.Id);

           if (fAdult != null)
            {
                fAdult.FirstName = adult.FirstName;
                fAdult.LastName = adult.LastName;
                fAdult.HairColor = adult.HairColor;
                fAdult.EyeColor = adult.EyeColor;
                fAdult.Age = adult.Age;
                fAdult.Weight = adult.Weight;
                fAdult.Height = adult.Height;
                fAdult.Sex = adult.Sex;
                fAdult.JobTitle = adult.JobTitle;
                fAdult.Salary = adult.Salary;
                await fctx.SaveChangesAsync();
            }
        }

        public async Task UpdateChild(Child child)
        {
            
            Child fChild =  await fctx.Families
                .SelectMany(f => f.Children).FirstAsync(c => c.Id == child.Id);
            
            if (fChild != null)
            {
                fChild.FirstName = child.FirstName;
                fChild.LastName = child.LastName;
                fChild.HairColor = child.HairColor;
                fChild.EyeColor = child.EyeColor;
                fChild.Age = child.Age;
                fChild.Weight = child.Weight;
                fChild.Height = child.Height;
                fChild.Sex = child.Sex;
                await fctx.SaveChangesAsync();
            }
        }

        public async Task UpdatePet(Pet pet)
        {
            
           Pet fPet = await fctx.Families.SelectMany(f => f.Pets).FirstAsync(p => p.Id == pet.Id);
           
            if (fPet != null)
            {
                fPet.Species = pet.Species;
                fPet.Name = pet.Name;
                fPet.Age = pet.Age;
                await fctx.SaveChangesAsync();
            }
        }

     

        public async Task UpdateAddress(string streetName, int houseNum, string nStName, int nHouseNumebr)
        {
            Family family = await fctx.Families.FirstAsync
                (f => f.HouseNumber == houseNum && f.StreetName.Equals(streetName));
            family.HouseNumber = nHouseNumebr;
            family.StreetName = nStName;
            await fctx.SaveChangesAsync();
        }

        public async Task<Adult> GetAdult(int id)
        {
            Adult adult =  await fctx.Families.SelectMany(f=> f.Adults).FirstAsync(a=> a.Id== id);

            return adult;
        }

        public async Task<Child> GetChild( int id)
        {
            Child child =   await fctx.Families.SelectMany(f=> f.Children).FirstAsync(c=> c.Id== id);
            return child;
        }

        public async Task<Pet> GetPet(int id)
        {

            Pet fPet = await fctx.Families.SelectMany(f => f.Pets).FirstAsync(p => p.Id == id);
            
            
            return fPet;
        }
        

        public async Task RemoveAdult( int id)
        {
            Adult adultToRemove = await fctx.Families.SelectMany(f=> f.Adults).FirstAsync(a => a.Id == id);

            fctx.Families.SelectMany(f => f.Adults).ToList().Remove(adultToRemove);
            await fctx.SaveChangesAsync();

        }

        public async Task RemoveChild(int id)
        {
            Child adultToRemove = await fctx.Families.SelectMany(f=> f.Children).FirstAsync(c => c.Id == id);

            fctx.Families.SelectMany(f => f.Children).ToListAsync().Result.Remove(adultToRemove);
            
            await fctx.SaveChangesAsync();

        }

        public async Task RemovePet(int id)
        {
            Pet petToRemove = await fctx.Families.SelectMany(f=> f.Pets).FirstAsync(p => p.Id == id);
            
            fctx.Families.SelectMany(f => f.Pets).ToList().Remove(petToRemove);
            
            await fctx.SaveChangesAsync();

        }
        

   
    }
}