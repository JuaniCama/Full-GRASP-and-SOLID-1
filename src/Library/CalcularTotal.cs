//Creo una nueva clase con el fin de calcular el total, respetando el principio de SRP de que cada clase tenga una única responsabilidad.
using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library{
    public class CalcularTotal{
        public static double GetProductionCost(Recipe receta)
        {
            double CostoInsumos = 0;
            double CostoEquipamiento = 0;
            foreach (Step step in receta.steps)
            {
                CostoInsumos += step.Input.UnitCost * step.Quantity;
                CostoEquipamiento += step.Equipment.HourlyCost * step.Time / 60;
            }
            double totalCost = CostoInsumos + CostoEquipamiento;

            return totalCost;
        }
    }
}