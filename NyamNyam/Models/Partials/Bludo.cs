﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam.Models
{
    public partial class Bludo
    {
        public string DishColor
        {
            get
            {
                foreach (var rec in App.DB.OneRechept.ToList())
                {
                    if (Id == rec.Rechept.Bludo.Id && rec.SumIng > rec.Ingredient.Kol)
                    {
                        return "Gray32Float";
                    }
                }
                return "Color32Float";
            }
        }
    }
}
