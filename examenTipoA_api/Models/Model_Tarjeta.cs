using System;
namespace examenTipoA_api.Models
{
	public class Model_Tarjeta
	{
        public int ID_tarjeta { get; set; }
        public int ID_cuenta { get; set; }
        public int Numero_tarjeta { get; set; }
        public string Tipo_tarjeta { get; set; }
        public DateTime Fecha_expiracion { get; set; }
    }
}

