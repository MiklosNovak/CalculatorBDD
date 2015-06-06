using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
	    int _value;

		public int Value 
		{ 
			get { return _value; } 
		}

	    public Calculator()
	    {
		    Reset();
	    }

	    public void Add(int x)
	    {
		    _value += x;
	    }

	    public void Reset()
	    {
		    _value = 0;
	    }
    }
}
