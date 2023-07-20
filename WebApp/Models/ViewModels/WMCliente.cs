using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApp.Models.ViewModels
{
    public class WMCliente
    {
       
        public int Idcliente { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "El Nombre de Cliente es obligatorio")]
        public string? NombreCliente { get; set; }

        public string? Direccion { get; set; }


    }
}
