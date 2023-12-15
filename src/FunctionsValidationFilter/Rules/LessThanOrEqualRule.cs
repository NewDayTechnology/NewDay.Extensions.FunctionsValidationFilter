﻿namespace FunctionsValidationFilter.Rules;

internal class LessThanOrEqualRule : Rule
{
    public int ValueToCompare { get; }

    public LessThanOrEqualRule(int valueToCompare)
    {
        ValueToCompare = valueToCompare;
    }
}
