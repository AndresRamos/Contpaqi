﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion
{
    public class SeleccionarValorClasificacionViewModel : ObservableRecipient
    {
        private string _filtro;
        private ValorClasificacion _valorSeleccionado;

        public SeleccionarValorClasificacionViewModel()
        {
            ValoresView = CollectionViewSource.GetDefaultView(Valores);
            ValoresView.Filter = ValoresView_Filter;

            SeleccionarCommand = new RelayCommand(Seleccionar, CanSeleccionar);
            CancelarCommand = new RelayCommand(Cancelar);
        }

        public string Title { get; } = "Seleccionar Valor De Clasificacion";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ValoresView.Refresh();
            }
        }

        public ObservableCollection<ValorClasificacion> Valores { get; } = new ObservableCollection<ValorClasificacion>();

        public ICollectionView ValoresView { get; }

        public ValorClasificacion ValorSeleccionado
        {
            get => _valorSeleccionado;
            set
            {
                SetProperty(ref _valorSeleccionado, value);
                RaiseGuards();
            }
        }

        public bool SeleccionoValor { get; private set; }

        public IRelayCommand SeleccionarCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public void Inicializar(IEnumerable<ValorClasificacion> valores)
        {
            SeleccionoValor = false;
            Valores.Clear();
            foreach (var valor in valores)
            {
                Valores.Add(valor);
            }

            ValorSeleccionado = Valores.FirstOrDefault();
        }

        public void Seleccionar()
        {
            SeleccionoValor = true;
            CerrarVista();
        }

        public bool CanSeleccionar()
        {
            return ValorSeleccionado != null;
        }

        public void Cancelar()
        {
            SeleccionoValor = false;
            ValorSeleccionado = null;
            CerrarVista();
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        private void RaiseGuards()
        {
            SeleccionarCommand.NotifyCanExecuteChanged();
        }

        private bool ValoresView_Filter(object obj)
        {
            var valor = obj as ValorClasificacion;
            if (valor is null)
            {
                throw new ArgumentException("El parametro no es un tipo valido", nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   valor.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   valor.Valor.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}