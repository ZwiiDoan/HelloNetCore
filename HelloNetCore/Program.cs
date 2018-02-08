using HelloNetCore.entity;
using System;

namespace HelloNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook GradeBook = new GradeBook();

            for (int i = 1; i <= 10; i++)
            {
                GradeBook.AddGrade((float)i);
            }

            Console.WriteLine(GradeBook.GetGradeStatistics().ToString());

        }
    }
}
