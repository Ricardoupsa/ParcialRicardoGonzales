using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialRicardoGonzalesDelgado.Models
{
    public class Country
    {
        //------------ ALPHA3CODE --------------------
        [Key]
        [Required]
        [StringLength(3, MinimumLength = 2)]
        [DisplayName("Abreviatura del pais de 3 letras ")]
        public string alpha3Code { get; set; }
        //-------------------------------------


        //--------- REGION --------------------
        [Required(ErrorMessage ="Ingrese la region")]
        public region Region { get; set; }
        //-------------------------------------


        //-------- NAME -----------------------
        [Required]
        [StringLength(25,MinimumLength =2)]
        [DisplayName("Ingrese el nombre del pais")]
        public string Name { get; set; }
        //-------------------------------------


        //---------AREA------------------------
        [Required]
        [DisplayName("Area del pais ingresado en Km^2")]
        public int Area { get; set; }
        //------------------------------------


        //------ CALLING_CODE-----------------
        [Required]
        [DisplayName("Ingrese el prefijo telefonico del pais ingresado")]
        public int CallingCode { get; set; }
        //-------------------------------------


        //------ LENGUAGES --------------------
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [DisplayName("Ingrese el lenguaje del pais ingresado")]
        public string Lenguages { get; set; }
        //-------------------------------------


        //------- FLAGS -----------------------
        [Required]
        [DisplayName("Ingrese el numero de la bandera del apis que corresponda a la siguiente lista: lanzateyviaja.com/mundo/paises-y-capitales")]
        public int Flag { get; set; }
        //-------------------------------------

    }
    public enum region {Sudamerica, Centro_America, Africa, Asia, Europa, Oceania}
}