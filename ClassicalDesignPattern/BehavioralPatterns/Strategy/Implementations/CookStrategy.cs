using ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Implementations
{
    public class CookStrategy : CookingStrategy
    {
        public CookStrategy(Context context) : base(context)
        {
        }

        public override string Cook()
        {
            var ingredients = Context.GetIngredients();
            return "We bake ";
        }
    }
}
