using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//la clase ComputadorasPartial implementa la interfaz IPrototype y 
//proporciona su propia implementación del método Clone(), lo que la convierte en la clase
//ConcretePrototype en este patrón.
namespace Entidades
{
    //ACÁ DEFINIMOS LA CLASE COMPUTADORAS QUE IMPLEMENTA LA INTERFAZ PROTOTYPE
    public partial class Computadoras : IPrototype
    {
        //ACÁ EL MÉTODO CLONE LLAMA AL METODO MEMBERWISECLONE() DE LA CLASE BASE
        //PARA CREAR UNA COPIA SUPERFICIAL DE LA INSTANCIA ACTUAL
        //ESTE MÉTODO DEVUELVE UN OBJETO DE TIPO OBJECT
        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }
    }
}
