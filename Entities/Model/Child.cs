using System;
using System.Collections.Generic;

namespace Entitiy

{
    public class Child : Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }
    }
}