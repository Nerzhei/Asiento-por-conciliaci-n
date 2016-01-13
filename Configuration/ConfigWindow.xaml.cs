using System.Data.SqlClient;
using System.Windows;

namespace ICG.Utiles.Configuracion
{
    /// <summary>
    /// Lógica de interacción para ConfigWindow.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        private ConfigEnt _config;
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBoxInstancia.Text) && !string.IsNullOrEmpty(TxtBoxDbGestion.Text) &&
                !string.IsNullOrEmpty(TxtBoxDbContable.Text) && !string.IsNullOrEmpty(TxtBoxUsuario.Text) &&
                !string.IsNullOrEmpty(TxtBoxPassword.Text))
            {
                _config = new ConfigEnt()
                {
                    Instancia = TxtBoxInstancia.Text,
                    DbGestion = TxtBoxDbGestion.Text,
                    DbContable = TxtBoxDbContable.Text,
                    Usuario = TxtBoxUsuario.Text,
                    Password = TxtBoxPassword.Text
                };
                using (var sqlConnection = new SqlConnection())
                {
                    try
                    {
                        sqlConnection.ConnectionString = ConfigLog.GetConnectionString(_config, 'G');
                        sqlConnection.Open();
                        sqlConnection.Close();
                        sqlConnection.ConnectionString = ConfigLog.GetConnectionString(_config, 'C');
                        sqlConnection.Open();
                        sqlConnection.Close();
                        TxtBoxInstancia.IsEnabled = false;
                        TxtBoxDbGestion.IsEnabled = false;
                        TxtBoxDbContable.IsEnabled = false;
                        TxtBoxUsuario.IsEnabled = false;
                        TxtBoxPassword.IsEnabled = false;
                        CheckBoxOk.IsChecked = true;
                        BtnTest.IsEnabled = false;
                        BtnSubmit.IsEnabled = true;
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Revise los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void BtnSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            ConfigLog.Create(_config);
            Close();
        }
    }
}
