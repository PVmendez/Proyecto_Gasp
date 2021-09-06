//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
//cambio
using System.Text;
using System.Collections.Generic;
using System.Linq;
//cambio

namespace Proyecto_Gasp.Library
{
    public class Recipe
    {
        private List<Step> steps = new List<Step>();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string PrintRecipe(bool verbose = false)
        {
            //cambio
            StringBuilder sb = new StringBuilder();

            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de {step.Input.Description} " + $"usando {step.Equipment.Description} durante {step.Time} segundos");
            }
            sb.Append("\n");
            sb.Append($"Costo total: ${this.TotalCost()}");
            return sb.ToString();

        }

            public double TotalCost() {

                double ts;
                ts = this.steps.Select(step => step.TotalCost).Sum();
                return ts;

            }
            //cambio
    }
}