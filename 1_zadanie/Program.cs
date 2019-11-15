using System;

namespace _1_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.PropertyChanged += (oldString, newString) => Console.WriteLine($"Mod wlasciwosci: Name, stara wartosc: {oldString}, Nowa wartość:  {newString}");

            product.Name = "Tomek";
            product.Name = "Janek";
            product.Name = "Witek";
        }
    }

    class Product
    {
        public event Action<string, string> PropertyChanged;
        private string _name;
        private double _price;

        public string Name
        {
            get { return _name; }
            set
            {
                string oldValue = _name;
                _name = value;

                PropertyChanged(oldValue, _name);
            }

           
        }

        public double Price { get; set; }




    }
}
