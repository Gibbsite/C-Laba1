using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public interface IStack
    {
        void Push(string value);
        string Read();
        string Pop();
    }
}
