﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace DynamicEconomy
{
    public class PriceModifierCategoryDefExtension : DefModExtension
    {
        public ModifierCategory category=ModifierCategory.None;
    }



    public class LocalPriceModifierDefExtension : DefModExtension
    {
        public List<BaseThingPriceMultipilerInfo> thingPriceMultipilers = new List<BaseThingPriceMultipilerInfo>();
        public List<BaseCategoryPriceMultipilerInfo> categoryPriceMultipilers = new List<BaseCategoryPriceMultipilerInfo>();
    }
}
