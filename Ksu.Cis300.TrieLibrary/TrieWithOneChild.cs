using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    class TrieWithOneChild : ITrie
    {
        private string emp;
        private ITrie han; //cuz he's solo XD
        private Label solo;

        public TrieWithOneChild(ITrie temp, Label x)
        {

            //online
            emp = "";
            han = temp;
            solo = x;

            if (solo = (string)emp) { throw new ArgumentException}
        }
        public ITrie Add(string s)
        {
            return han.Add(s);
        }

        public bool Contains(string s)
        {
            //throw new NotImplementedException();
            return false;
        }
    }
}
