using ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.BehavioralPatterns.Strategy.Abstractions
{
    public abstract class CookingStrategy
    {
        protected Context Context { get; }

        public CookingStrategy(Context context)
        {
            Context = context;
        }

        public abstract string Cook();
    }
}
