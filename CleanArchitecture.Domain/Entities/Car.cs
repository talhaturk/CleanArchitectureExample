using CleanArchitecture.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Car : Entity
    {
        public Car()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public int EnginePower { get; set; }
    }
}
