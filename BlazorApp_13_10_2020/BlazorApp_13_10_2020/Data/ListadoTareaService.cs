using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_13_10_2020.Data
{
    public class ListadoTareaService
    {
        public Tarea[] GetListadoTareaAsync()
        {
            Tarea[] res = new Tarea[5];

            res[0] = new Tarea {Id=1 , Titulo= "Tarea 1" , Estado=false , Estimacion=10 , ResponsableId=1 ,Vencimiento="10/10/2020" };
            res[1] = new Tarea { Id = 2, Titulo = "Tarea 2", Estado = true, Estimacion = 16, ResponsableId = 2, Vencimiento = "16/10/2020" };
            res[2] = new Tarea { Id = 3, Titulo = "Tarea 3", Estado = false, Estimacion = 20, ResponsableId = 3, Vencimiento = "19/10/2020" };
            res[3] = new Tarea { Id = 4, Titulo = "Tarea 4", Estado = true, Estimacion = 13, ResponsableId = 5, Vencimiento = "25/10/2020" };
            res[4] = new Tarea { Id = 5, Titulo = "Tarea 5", Estado = false, Estimacion = 18, ResponsableId = 6, Vencimiento = "30/10/2020" };

            return res;

        }


    }
}
