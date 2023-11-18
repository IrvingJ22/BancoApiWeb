using System;
namespace examenTipoA_api.Models
{
	public class Model_Usuario
	{
        public int ID_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contrasena_usuario { get; set; }
        public string Tipo_usuario { get; set; }
        public float Saldo_usuario { get; set; }

    }
}
