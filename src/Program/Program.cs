//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            PopulateCatalogs(catalog);

            Recipe recipe = new Recipe();

            recipe.FinalProduct = catalog.GetProduct("Café con leche");
            recipe.AddStep(catalog.GetProduct("Café"), 100, catalog.GetEquipment("Cafetera"), 120);
            recipe.AddStep(catalog.GetProduct("Leche"), 200, catalog.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs(Catalog catalog)
        {
            catalog.AddProductToCatalog("Café", 100);
            catalog.AddProductToCatalog("Leche", 200);
            catalog.AddProductToCatalog("Café con leche", 300);

            catalog.AddEquipmentToCatalog("Cafetera", 1000);
            catalog.AddEquipmentToCatalog("Hervidor", 2000);
        }
    }
}
