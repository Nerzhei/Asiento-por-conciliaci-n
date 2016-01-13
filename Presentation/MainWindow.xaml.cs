using System;
using System.ComponentModel;
using System.Windows;
using ICG.Utiles.Configuracion;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ConfigEnt Config;
        public MainWindow()
        {
            InitializeComponent();
            Config = ConfigLog.Read();
            if (Config == null)
            {
                new ConfigWindow().ShowDialog();
                Config = ConfigLog.Read();
                if (Config == null)
                {
                    MessageBox.Show("Debe configurar la aplicacion para utilizarla", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    Close();
                }
            }
        }

        private void DoWork(object sender, DoWorkEventArgs e, DateTime fechaini, DateTime fechafin)
        {
            
        }

        private void BtnSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            if (DatePickerFechaIni.SelectedDate != null && DatePickerFechaFin.SelectedDate != null)
            {
                var fechaini = DatePickerFechaIni.SelectedDate.Value;
                var fechafin = DatePickerFechaFin.SelectedDate.Value;
                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += (sender2, e2) => DoWork(sender2, e2, fechaini, fechafin);
            }
        }
    }
}
