using System;
using System.Collections.Generic;
using System.Text;

namespace cd
{
    public interface Ientregable
    {

        bool entregar();
        bool devolver();
        bool IsEntregado();

        int compareTo(Object cd);

        
    }
}
