using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consZoo2
{
    public interface IFly
    {
        int NumberOfWings { get; set; }
        void Fly();
    }
}
