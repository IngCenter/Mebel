using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebel
{
    interface WithInstruction
    {
        //Получить адрес инструкции
        string getInstrAddress();
    }

    interface WithoutInstruction
    {
        string whyNoInstruction();
    }
}
