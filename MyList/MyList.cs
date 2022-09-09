using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercises
{
    public class MyList
    {

        public MyList(int valuie)
        {
            Value = valuie;
        }
        public MyList Next { get;set; }
        public MyList Previous { get; set; }
        public int Value { get; set; }

    }
}
