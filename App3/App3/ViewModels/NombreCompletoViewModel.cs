using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App3.ViewModels
{
    public class NombreCompletoViewModel : BaseViewModel
    {
        private string nombre;
        private string app;
        private string apm;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(nombreCompleto));
            }
        }
        public string ApP
        {
            get => app;
            set
            {
                if (string.Equals(app, value)) return;
                app = value;
                OnPropertyChanged(nameof(ApP));
                OnPropertyChanged(nameof(nombreCompleto));
            }
        }
        public string ApM
        {
            get => apm;
            set
            {
                if (string.Equals(apm, value)) return;
                apm = value;
                OnPropertyChanged(nameof(ApM));
                OnPropertyChanged(nameof(nombreCompleto));
            }
        }

        public string nombreCompleto => $"{Nombre} {ApP} {ApM}";
    }
}
