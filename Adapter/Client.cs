using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        private ITarget _target;
        public Client(ITarget target)
        {
            _target = target;
        }
        public void Request()
        {
            _target.MethodA();
        }
    }
}
