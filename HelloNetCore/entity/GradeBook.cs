using System;
using System.Collections.Generic;
using System.Text;

namespace HelloNetCore.entity
{
    public class GradeBook
    {
        private List<float> GradeList { get; set; }

        private GradeStatistics GradeStatistics;

        public string Name { get; set; }

        public GradeStatistics GetGradeStatistics()
        {
            if (GradeStatistics == null)
            {
                ComputeGradeStatistics();
            }

            return GradeStatistics;
        }

        public GradeBook()
        {
            GradeList = new List<float>();
        }

        public void AddGrade(float grade)
        {
            GradeList.Add(grade);
        }

        private void ComputeGradeStatistics()
        {
            GradeStatistics = new GradeStatistics();

            float totalGrade = 0;

            GradeStatistics.LowestGrade = GradeList[0];
            GradeStatistics.HighestGrade = GradeList[0];

            GradeList.ForEach(grade =>
            {
                totalGrade += grade;
                GradeStatistics.LowestGrade = Math.Min(GradeStatistics.LowestGrade, grade);
                GradeStatistics.HighestGrade = Math.Max(GradeStatistics.HighestGrade, grade);
            });

            GradeStatistics.AverageGrade = totalGrade / GradeList.Count;
        }
    }
}
