using System;
namespace examenTipoA_api.DTO
{
	public class DTO_Tarjeta
	{
        public int ID_tarjeta { get; set; }
        public int ID_cuenta { get; set; }
        public int Numero_tarjeta { get; set; }
        public string Tipo_tarjeta { get; set; }
        public DateTime Fecha_expiracion { get; set; }

        public DTO_Tarjeta(int idT, int idC, int numero, string tipo, DateTime fechaEx)
		{
            ID_tarjeta = idT;
            ID_cuenta = idC;
            Numero_tarjeta = numero;
            Tipo_tarjeta = tipo;
            Fecha_expiracion = fechaEx;
		}
	}
}

