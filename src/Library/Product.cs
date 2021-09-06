//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Proyecto_Gasp.Library
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }

        //cambio
        public double TotalCost(double quantity) {

            double tq;
            tq = this.UnitCost * quantity;
            return tq;
        }
        //cambio
    }
}