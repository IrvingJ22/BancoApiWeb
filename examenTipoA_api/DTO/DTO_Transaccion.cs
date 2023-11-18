using System;
namespace examenTipoA_api.DTO
{
	public class DTO_Transaccion
	{
        public int ID_transaccion { get; set; }
        public int ID_cuenta { get; set; }
        public DateTime Fecha_transaccion { get; set; }
        public string Tipo_transaccion { get; set; }
        public float Monto_transaccion { get; set; }
        public string Descripcion_transaccion { get; set; }

        public DTO_Transaccion(int idT, int idC, DateTime fecha, string tipo, float monto, string descrip) 
		{
            ID_transaccion = idT;
            ID_cuenta = idC;
            Fecha_transaccion = fecha;
            Tipo_transaccion = tipo;
            Monto_transaccion = monto;
            Descripcion_transaccion = descrip;
		}
	}
}

