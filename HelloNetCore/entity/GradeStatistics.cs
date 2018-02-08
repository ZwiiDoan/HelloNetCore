using System;
using System.Collections.Generic;
using System.Text;

namespace HelloNetCore.entity
{
    public class GradeStatistics
    {
        public float HighestGrade { get; set; }

        public float LowestGrade { get; set; }

        public float AverageGrade { get; set; }

        override
        public string ToString()
        {
            return "Highest Grade = " + HighestGrade + "; LowestGrade = " + LowestGrade + "; AverageGrade = " + AverageGrade;
        }
    }
}
