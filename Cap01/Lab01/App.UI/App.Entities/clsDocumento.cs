using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Entities.Events.clsListeners; //LOS EVENTOS SON ESTATICOS

namespace App.Entities
{
    public class clsDocumento
    {
        public event DespuesCalcular onDespuesCalcular;

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        //EN EL METODO SE PONE VIRTUAL PARA QUE LOS HIJOS PUEDAN SOBRE ESCRIBIR EL METODO
        public virtual void Calcular()
        {
            if (onDespuesCalcular != null)
            {
                onDespuesCalcular(this); //THIS REPRESENTA A LA CLASE ACTUAL

            }
        }

    }
}
