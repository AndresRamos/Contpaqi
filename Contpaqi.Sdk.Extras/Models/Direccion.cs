﻿using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Direccion : IDireccion
    {
        public string CodigoClienteProveedor { get; set; }

        public TipoCatalogoDireccion TipoCatalogo { get; set; }

        public TipoDireccionEnum TipoDireccion { get; set; }

        public string NombreCalle { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterior { get; set; }

        public string Colonia { get; set; }

        public string CodigoPostal { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Telefono3 { get; set; }

        public string Telefono4 { get; set; }

        public string Email { get; set; }

        public string DireccionWeb { get; set; }

        public string Ciudad { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string TextoExtra { get; set; }

        // Propiedades Extras
        public int Id { get; set; }

        public int IdCatalogo { get; set; }
    }
}