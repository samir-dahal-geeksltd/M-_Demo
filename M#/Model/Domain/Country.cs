﻿using MSharp;

namespace Domain
{
    public class Country : EntityType
    {
        public Country()
        {
            String("Name").Mandatory().Unique();
          //  UniqueCombination(new[] { "Name" });
        }
    }
}