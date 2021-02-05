using MSharp;

namespace Domain
{
    public class Bike : SubType<Vehicle>
    {
        public Bike()
        {
            Bool("Requires license").Mandatory();
        }
    }
}