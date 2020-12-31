using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DSA_ASSIGNMENT_NEW
{
    public class Declared_Variables
    {
        //Declaring Variables with data

        public List<string> FirstNames = new List<string>();
        List<string> LastNames = new List<string>();
        List<string> StudentNumbers = new List<string>();
        static int[] Scores = new int[4] { 100, 75, 89, 94 };
        double avgScores = Queryable.Average(Scores.AsQueryable());
        //Declaring Variables with data

    }
}
