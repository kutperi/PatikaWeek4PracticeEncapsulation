using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticeEncapsulation
{
    public class Car // Creating a new class
    {
        // Fields
        private string _brand;
        private string _model;
        private string _colour;
        private int _gateCount;

        //Properties
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public string Colour { get; set; }

        public int GateCount // Task instruction that encapsulates gate counting
        { 
            get 
            { 
                return _gateCount; 
            } 
            set 
            {
                if (value == 2 || value == 4) // Checking 2 or 4 situations
                {
                    _gateCount = value;
                }
                else // if not making gatecount -1
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olabilir başka seçeneğimiz yoktur.");
                    _gateCount = -1;
                }
            } 
        }

        public void CarInfo() // Method to show car informations
        {
            Console.WriteLine($"Marka --> {Brand}\nModel --> {Model}\nRenk --> {Colour}\nKapı Sayısı --> {GateCount}");
        }

    }
}
