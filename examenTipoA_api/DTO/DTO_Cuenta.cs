using System;
namespace examenTipoA_api.DTO
{
	public class DTO_Cuenta
	{
        public int ID_cuenta { get; set; }
        public int ID_usuario { get; set; }
        public int Numero_cuenta { get; set; }
        public string Tipo_cuenta { get; set; }
        public float Saldo_cuenta { get; set; }

        public DTO_Cuenta (int id, int idU, int numero, string tipo, float saldo)
        {
            ID_cuenta = id;
            ID_usuario = idU;
            Numero_cuenta = numero;
            Tipo_cuenta = tipo;
            Saldo_cuenta = saldo;
        }
    }
}

