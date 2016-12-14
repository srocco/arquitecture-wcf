using PoC.Fwk.Domain;
using System;

namespace PoC.Entities {
    public class Product: Entity<Int64> {

        public String Name { get; set; }
    }
}
