using System;
namespace examenTipoA_api.Models
{
	public class Model_Transaccion
	{
        public int ID_transaccion { get; set; }
        public int ID_cuenta { get; set; }
        public DateTime Fecha_transaccion { get; set; }
        public string Tipo_transaccion { get; set; }
        public float Monto_transaccion { get; set; }
        public string Descripcion_transaccion { get; set; }
    }
}

