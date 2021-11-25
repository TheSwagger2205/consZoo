using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consZoo2
{
    public interface ISwim
    {
        int NumberOfFinns { get; set; }
        void Swim();
    }
}
