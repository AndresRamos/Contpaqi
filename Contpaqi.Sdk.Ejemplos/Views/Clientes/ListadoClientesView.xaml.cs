﻿using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Clientes
{
    /// <summary>
    ///     Interaction logic for ListadoClientesView.xaml
    /// </summary>
    public partial class ListadoClientesView
    {
        public ListadoClientesView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoClientesViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoClientesViewModel ViewModel => (ListadoClientesViewModel) DataContext;
    }
}