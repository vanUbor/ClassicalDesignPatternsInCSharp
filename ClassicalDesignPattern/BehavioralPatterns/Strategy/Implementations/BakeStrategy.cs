using ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Implementations
{
    public class BakeStrategy : CookingStrategy
    {
        public BakeStrategy(Context context) : base(context)
        {
        }

        public override string Cook()
        {
            return "Baking ingrediants: " + string.Join(',', Context.GetIngredients());
        }
    }
}
