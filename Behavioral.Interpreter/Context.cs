using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Interpreter
{
    /// <summary>
    /// Context class
    /// </summary>
    class Context
    {
        private string _inputString;
        private int _outputDigit;

        // Constructor
        public Context(string input)
        {
            this._inputString = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return _inputString; }
            set { _inputString = value; }
        }

        // Gets or sets output
        public int Output
        {
            get { return _outputDigit; }
            set { _outputDigit = value; }
        }
    }
}
