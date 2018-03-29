using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_usuarioBO
    {
        private int id_usuario;
        private string username;
        private string password;
        private int id_perfil; // preguntar si va esto aqui


        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
    }
}
