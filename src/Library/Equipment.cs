//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Proyecto_Gasp.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }

        //cambio
        public double TotalCost(int minutes) {

            double th;
            th = this.HourlyCost * minutes / 60;
            return th;

        } 
        //cambio
    }
}