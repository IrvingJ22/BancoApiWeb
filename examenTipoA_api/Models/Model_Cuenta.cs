using System;
namespace examenTipoA_api.Models
{
	public class Model_Cuenta
	{
        public int ID_cuenta { get; set; }
        public int ID_usuario { get; set; }
        public int Numero_cuenta { get; set; }
        public string Tipo_cuenta { get; set; }
        public float Saldo_cuenta { get; set; }
    }
}

