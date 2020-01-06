using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Product_Inheritance.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price);
            sb.Append(" (Manufactured date: ");
            sb.Append($"{ManufacturedDate.ToString("dd/MM/yyyy")})");
            
            return sb.ToString();
        }
    }
}
