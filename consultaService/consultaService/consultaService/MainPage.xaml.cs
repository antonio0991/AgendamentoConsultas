using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consultaService.model;
using consultaService.service;
using Xamarin.Forms;

namespace consultaService
{
    public partial class MainPage : ContentPage
    {
        private ConsultaService consultaService;
        public ObservableCollection<Consulta> consultas;

        public MainPage()
        {
            InitializeComponent();

            consultaService = new ConsultaService();
            consultas = new ObservableCollection<Consulta>();

            lstConsultas.ItemsSource = consultas;
            getAllConsulta();
        }

        private async void getAllConsulta()
        {
            var consultasRes = await consultaService.GetAll();
            foreach (var consulta in consultasRes)
            {
                consultas.Add(consulta);
            }
        }
    }
}
