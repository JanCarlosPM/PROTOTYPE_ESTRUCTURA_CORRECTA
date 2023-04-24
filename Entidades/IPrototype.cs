using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //EN ESTÁ INTERFAZ DEFINIMOS UN MÉTODO CLONE() PARA CREAR COPIAS EXACTAS//
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
