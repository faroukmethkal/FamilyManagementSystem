using System.Collections.Generic;
using System.Threading.Tasks;
using Entitiy;

namespace Domain.Data
{
    public interface IFamilyRepo
    {
        Task<IList<Entitiy.Family>> getAllFamily(int? minAdultAge, int? maxAdultAge,
            bool? hasChild, bool? hasPet);
        Task<IList<Adult>> getAllAdult(string streetName, int houseNum);
        Task<IList<Child>> getAllChildren(string streetName, int houseNum);
        Task<IList<Pet>> getAllPets(string streetName, int houseNum);
        Task AddNewAdult(string streetName, int houseNum, Adult adult);
        Task AdNewChild(string streetName, int houseNum, Child child);
        Task AddNewPet(string streetName, int houseNum, Pet pet);
        Task AddNewChildPet(int childId, Pet pet);

        Task UpdateAdult(Adult adult);
        Task UpdateChild( Child child);
        Task UpdatePet(Pet pet);
        Task UpdateAddress(string streetName, int houseNum, string StName, int HouseNumebr);

        Task<Adult> GetAdult( int id);
        Task<Child> GetChild(int id);
        Task<Pet> GetPet( int id);
        
        Task RemoveAdult( int id);

        Task RemoveChild(int id);

        Task RemovePet(int id);

    }
}