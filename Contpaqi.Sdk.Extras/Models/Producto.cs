﻿using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Producto : IProducto
    {
        // Propiedades tProducto
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Tipo { get; set; }

        public string FechaAlta { get; set; }

        public string FechaBaja { get; set; }

        public int Status { get; set; }

        public int ControlExistencia { get; set; }

        public int MetodoCosteo { get; set; }

        public string CodigoUnidadBase { get; set; }

        public string CodigoUnidadNoConvertible { get; set; }

        public double Precio1 { get; set; }

        public double Precio2 { get; set; }

        public double Precio3 { get; set; }

        public double Precio4 { get; set; }

        public double Precio5 { get; set; }

        public double Precio6 { get; set; }

        public double Precio7 { get; set; }

        public double Precio8 { get; set; }

        public double Precio9 { get; set; }

        public double Precio10 { get; set; }

        public double Impuesto1 { get; set; }

        public double Impuesto2 { get; set; }

        public double Impuesto3 { get; set; }

        public double Retencion1 { get; set; }

        public double Retencion2 { get; set; }

        public string NombreCaracteristica1 { get; set; }

        public string NombreCaracteristica2 { get; set; }

        public string NombreCaracteristica3 { get; set; }

        public string CodigoValorClasificacion1 { get; set; }

        public string CodigoValorClasificacion2 { get; set; }

        public string CodigoValorClasificacion3 { get; set; }

        public string CodigoValorClasificacion4 { get; set; }

        public string CodigoValorClasificacion5 { get; set; }

        public string CodigoValorClasificacion6 { get; set; }

        public string TextoExtra1 { get; set; }

        public string TextoExtra2 { get; set; }

        public string TextoExtra3 { get; set; }

        public string FechaExtra { get; set; }

        public double ImporteExtra1 { get; set; }

        public double ImporteExtra2 { get; set; }

        public double ImporteExtra3 { get; set; }

        public double ImporteExtra4 { get; set; }

        // Propiedades Extra
        public int Id { get; set; }

        public string SegmentoContable1 { get; set; }

        public string ClaveSat { get; set; }

        public int IdUnidadBase { get; set; }

        public int IdUnidadNoConvertible { get; set; }

        public int IdValorClasificacion1 { get; set; }

        public int IdValorClasificacion2 { get; set; }

        public int IdValorClasificacion3 { get; set; }

        public int IdValorClasificacion4 { get; set; }

        public int IdValorClasificacion5 { get; set; }

        public int IdValorClasificacion6 { get; set; }

        public UnidadMedida UnidadBase { get; set; }

        public UnidadMedida UnidadNoConvertible { get; set; }

        public ValorClasificacion ValorClasificacion1 { get; set; }

        public ValorClasificacion ValorClasificacion2 { get; set; }

        public ValorClasificacion ValorClasificacion3 { get; set; }

        public ValorClasificacion ValorClasificacion4 { get; set; }

        public ValorClasificacion ValorClasificacion5 { get; set; }

        public ValorClasificacion ValorClasificacion6 { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }
    }
}