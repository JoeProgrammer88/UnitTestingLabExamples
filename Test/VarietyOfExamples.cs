using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test;

public class VarietyOfExamples
{
    /// <summary>
    /// Determines if a year is a leap year
    /// </summary>
    /// <param name="year">The year to check</param>
    /// <returns></returns>
    public bool IsLeapYear(int year)
    {
        return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
    }
}

