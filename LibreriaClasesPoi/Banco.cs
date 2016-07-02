using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class Banco:PoiConServicios
    {
        public Banco(int id, string nombre, Coordenada coordenadaa) 
        {
            base.init(id, nombre, coordenadaa);
            base.initService();
            agregarHorariosFijos();
        }
        public void agregarHorariosFijos()
        {
            Dictionary<string, rango> horariosDeBancos = new Dictionary<string, rango>();
            agregarDiaYHorario(horariosDeBancos, "lunes", 10, 12, 12, 15, 0,0 );
            agregarDiaYHorario(horariosDeBancos, "martes", 10, 12, 12, 15, 0, 0);
            agregarDiaYHorario(horariosDeBancos, "miercoles", 10, 12, 12, 15, 0, 0);
            agregarDiaYHorario(horariosDeBancos, "jueves", 10, 12, 12, 15, 0, 0);
            agregarDiaYHorario(horariosDeBancos, "viernes", 10, 12, 12, 15, 0, 0);

        }
    }
}
