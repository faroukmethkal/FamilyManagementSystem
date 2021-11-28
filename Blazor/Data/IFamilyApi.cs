using System.Collections.Generic;
using System.Threading.Tasks;
using Entitiy;

namespace Blazor.Data
{
    public interface IFamilyApi
    {
        Task<IList<Family>> getAllFamily(int? minAdultAge, int? maxAdultAge,
            bool? hasChild, bool? hasPet);

        Task<IList<Adult>> getAllAdult(string streetNum, int houseNum);
        Task<IList<Child>> getAllChildren(string streetNum, int houseNum);
        Task<IList<Pet>> getAllPets(string streetNum, int houseNum);
        Task AddNewAdult(string streetNum, int houseNum, Adult adult);
        Task AdNewChild(string streetNum, int houseNum, Child child);
        Task AddNewPet(string streetNum, int houseNum, Pet pet);
        Task AddNewChildPet(int childId, Pet pet);

        Task UpdateAdult(Adult adult);
        Task UpdateChild( Child child);
        Task UpdatePet(Pet pet);
        Task UpdateAddress(string streetNum, int houseNum, string StName, int HouseNumebr);

        Task<Adult> GetAdult( int id);
        Task<Child> GetChild(int id);
        Task<Pet> GetPet( int id);
        
        Task RemoveAdult( int id);
        Task RemovePet(int id);
        Task RemoveChild(int id);

    }
}