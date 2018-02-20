using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class MenuItem
    {
        private string name;
        private double price;
        private int quantity;

        public MenuItem(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }
        public MenuItem(string n)
        {
            Name = n;
        }
        public int Quantity {
            get
            {
                if (quantity < 0)
                    return 1;
                else
                    return quantity;
            }
            set { quantity = value; }
        }

        public string Combo
        {
            get
            {
                if (Price != 0)
                {
                    return $"{Name} ${Price}";
                }
                else
                {
                    return Name;
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            private set
            {
                price = value;
            }
        }

        private void OnNotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
