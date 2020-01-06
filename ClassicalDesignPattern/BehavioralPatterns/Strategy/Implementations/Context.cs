using ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Abstractions;
using ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Implementations
{
    public class Context
    {


        private string[] _ingredients = new[] { "Noodles", "Chilli", "Oil", "Cheese", "Garlic" };
        CookStrategy _strategy;

        public string[] GetIngredients()
        {
            return _ingredients;
        }

        public string MakeFavouriteDish(HowTo strat)
        {
            LoadStrategy(strat);
            return _strategy.Cook();
        }

        private CookingStrategy LoadStrategy(HowTo strat)
        {
            switch (strat)
            {
                case HowTo.Cook:
                    return new CookStrategy(this);
                case HowTo.Bake:
                    return new BakeStrategy(this);
                default:
                    throw new NotSupportedException("I have no idea how to cook!");
            }
        }
    }
}
