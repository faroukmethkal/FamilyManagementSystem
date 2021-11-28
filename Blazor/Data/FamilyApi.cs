using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entitiy;
using Newtonsoft.Json;

namespace Blazor.Data
{
    public class FamilyApi : IFamilyApi
    {
        private HttpClient client;

        public FamilyApi(HttpClient client)
        {
            this.client = client;
        }
        

        public async Task<IList<Family>> getAllFamily(int? minAdultAge, int? maxAdultAge, bool? hasChild, bool? hasPet)
        {
            HttpResponseMessage response = await client
                .GetAsync(
                    $"families?minAdultAge={minAdultAge}&maxAdultAge={maxAdultAge}&hasChild={hasChild}&hasPet={hasPet}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("server Error");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var families = JsonConvert.DeserializeObject<IList<Family>>(jsonResponse);
            return families;
        }

        public async Task<IList<Adult>> getAllAdult(string streetName, int houseNum)
        {
            HttpResponseMessage response = await client
                .GetAsync(
                    $"adults?streetName={streetName}&houseNum={houseNum}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var adults = JsonConvert.DeserializeObject<IList<Adult>>(jsonResponse);
            return adults;
        }

        public async Task<IList<Child>> getAllChildren(string streetName, int houseNum)
        {
            HttpResponseMessage response = await client
                .GetAsync(
                    $"children?streetName={streetName}&houseNum={houseNum}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var children = JsonConvert.DeserializeObject<IList<Child>>(jsonResponse);
            return children;
        }

        public async Task<IList<Pet>> getAllPets(string streetName, int houseNum)
        {
            HttpResponseMessage response = await client
                .GetAsync(
                    $"children?streetName={streetName}&houseNum={houseNum}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var pets = JsonConvert.DeserializeObject<IList<Pet>>(jsonResponse);
            return pets;
        }

        public async Task AddNewAdult(string streetName, int houseNum, Adult adult)
        {
            var adultAsJson = JsonConvert.SerializeObject(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8,
                "application/json");
            var response = await client.PostAsync($"adults?streetName={streetName}&houseNum={houseNum}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task AdNewChild(string streetName, int houseNum, Child child)
        {
            var childAsJson = JsonConvert.SerializeObject(child);
            HttpContent content = new StringContent(childAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"children?streetName={streetName}&houseNum={houseNum}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task AddNewPet(string streetName, int houseNum, Pet pet)
        {
            var petAsJson = JsonConvert.SerializeObject(pet);
            HttpContent content = new StringContent(petAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"pets?streetName={streetName}&houseNum={houseNum}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task AddNewChildPet(int childId, Pet pet)
        {
            var petAsJson = JsonConvert.SerializeObject(pet);
            HttpContent content = new StringContent(petAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"children/pets?childId={childId}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task UpdateAdult(Adult adult)
        {
            var adultAsJson = JsonConvert.SerializeObject(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8,
                "application/json");
            var response = await client.PutAsync($"adults", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task UpdateChild(Child child)
        {
            var childAsJson = JsonConvert.SerializeObject(child);
            HttpContent content = new StringContent(childAsJson, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"children", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task UpdatePet(Pet pet)
        {
            var petAsJson = JsonConvert.SerializeObject(pet);
            HttpContent content = new StringContent(petAsJson, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"pets", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }
        

        public Task UpdateAddress(string streetName, int houseNum, string StName, int HouseNumebr)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Adult> GetAdult(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"adult?aId={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }

            var adultJson = await responseMessage.Content.ReadAsStringAsync();
            Adult adult = JsonConvert.DeserializeObject<Adult>(adultJson);

            return adult;
        }

        public async Task<Child> GetChild(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"child?id={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }

            var childJson = await responseMessage.Content.ReadAsStringAsync();
            Child child = JsonConvert.DeserializeObject<Child>(childJson);

            return child;
        }

        public async Task<Pet> GetPet(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"pet?pId={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }

            var petAsJson = await responseMessage.Content.ReadAsStringAsync();
            Pet pet = JsonConvert.DeserializeObject<Pet>(petAsJson);

            return pet;
        }
        

        public async Task RemoveAdult(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"adults?aId={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }
            
        }

        public async Task RemoveChild(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"children?cId={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }
            
        }

        public async Task RemovePet(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"pets?pId={id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error, no response");
            }
        }
        
    }
}