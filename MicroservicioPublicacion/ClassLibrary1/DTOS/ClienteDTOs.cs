using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO.DTOS
{
    public class ClienteDTOs
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }
        public int Usuario { get; set; }
    }
}
