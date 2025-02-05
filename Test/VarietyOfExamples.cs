using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test;

public class VarietyOfExamples
{
    public bool IsLeapYear(int year)
    {
        return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
    }
}

