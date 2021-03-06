using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Nombre")]
        [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string nombreCliente { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Correo")]
        [EmailAddress]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string mailCliente { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Contraseña")]
        [MaxLength(10, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string passwordCliente { get; set; }

        [Display(Name = "Nombre empresa")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string empresaCliente { get; set; }
        
        [Display(Name = "Cuit empresa")]
        [MaxLength(11, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string cuitCliente { get; set; }

        [Display(Name = "Domicilio empresa")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string domicilioCliente { get; set; }

        //RELACIONES CON OTRAS ENTIDADES

        [Display(Name = "Membresia")]
        [EnumDataType(typeof(PrecioCliente))]
        public PrecioCliente precioCliente { get; set; }



    }
}
