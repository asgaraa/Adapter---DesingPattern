using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptaa : ITarget
    {
        private Adaptee _adaptee;

        public Adaptaa(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void MethodA()
        {
            _adaptee.MethodB();  //Calling Adaptee method via Adapter
        }
    }
}
