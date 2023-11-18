using System;
namespace examenTipoA_api.DTO
{
	public class DTO_Usuario
	{
		public int ID_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contrasena_usuario { get; set; }
        public string Tipo_usuario { get; set; }
		public float Saldo_usuario { get; set; }

        public DTO_Usuario(int id, string nombre, string contrasena, string tipo, float saldo)
        {
            ID_usuario = id;
            Nombre_usuario = nombre;
            Contrasena_usuario = contrasena;
            Tipo_usuario = tipo;
            Saldo_usuario = saldo;
        }
    }
}

