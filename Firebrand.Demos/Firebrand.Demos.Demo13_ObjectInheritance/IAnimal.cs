using System;
namespace Firebrand.Demos
{
    public interface IAnimal
    {
        void DisplayName();
        int NumberOfLegs { get; set; }
        void Vocalize();
    }
}
