﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Product_Inheritance.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice());
            sb.Append(" (Customs fee: $ ");
            sb.Append($"{CustomsFee})");

            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
