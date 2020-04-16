using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2000s";
        public string Make { get; set; } = "American";
        public string Model { get; set; } = "Sedan";
        public abstract var DriveAbstract(Vehicle vehicle);

        public virtual var DriveVirtual(Vehicle vehicle);
        {
        }
    }   
}
    
            //DONE * Create an abstract class called Vehicle
            //DONE * The vehicle class shall have three string properties Year, Make, and Model
            //DONE * Set the defaults to something generic in the Vehicle class
            // * Vehicle shall have an abstract method called DriveAbstract with no implementation
            // * Vehicle shall have a virtual method called DriveVirtual with a base implementation.