using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class ViewJourney : Form
    {
        public class Journey
        {
            public string? Viaje { get; set; }
            public string? Fecha { get; set; }
            public string? Chofer { get; set; }
            public string? Salida { get; set; }
            public string? Caja { get; set; }
            public string? Saldo { get; set; }
            public string? Asientos { get; set; }
        }

        public class Truck
        {
            public string? id { get; set; }
            public string? modelo { get; set; }
            public string? patente { get; set; }
            public string? url_sheet { get; set; }
            public string? engrasado { get; set; }
            public string? service { get; set; }
            public string? vtv { get; set; }
            public string? rutas { get; set; }
            public string? senasa { get; set; }
            public string? poliza { get; set; }
            public bool? status { get; set; }
        }

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Google Sheets API .NET Quickstart";

        public ViewJourney()
        {
            InitializeComponent();

            GetTrucks();

            Initialize();
        }

        private void GetTrucks()
        {
            var path = @".\trucks.json";
            List<Truck> trucks;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    trucks = JsonConvert.DeserializeObject<List<Truck>>(json);
                    if (trucks != null)
                    {
                        foreach (Truck truck in trucks)
                        {
                            if ((bool)truck.status)
                                cBoxCamion.Items.Add(truck.patente);
                        }
                        cBoxCamion.SelectedIndex = 0;
                    }
                }
            }
        }

        public void Initialize()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            //String spreadsheetId = "1AwVknEEAYR8EGrJ_Xg1Ygxc8eh_1zyiHxhb1_zYZmk0";

            String spreadsheetId = SearchSheetID();

            String sheet = "Hoja 1";


            //Get VIAJE FECHA CHOFER
            var range = $"{sheet}!A1:E3";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            var response = request.Execute();
            IList<IList<object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                txtViaje.Text = values[0][1].ToString();
                txtFecha.Text = values[1][1].ToString();
                txtChofer.Text = values[2][1].ToString();
                //txtCamion.Text = values[1][4].ToString();
                txtAcoplado.Text = values[2][4].ToString();
            }
            else
            {
                Console.WriteLine("No data found.");
            }


            //Get SALIDA DESTINO
            range = $"{sheet}!B6:H7";
            request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;
            if (values != null && values.Count > 0)
            {
                try
                {
                    txtSalidaLugar1.Text = values[0][0].ToString();
                    txtSalidaFecha1.Text = values[0][1].ToString();
                    txtSalidaKilometros1.Text = values[0][2].ToString();

                    txtDestinoLugar1.Text = values[0][4].ToString();
                    txtDestinoFecha1.Text = values[0][5].ToString();
                    txtDestinoKilometros1.Text = values[0][6].ToString();

                    txtSalidaLugar2.Text = values[1][0].ToString();
                    txtSalidaFecha2.Text = values[1][1].ToString();
                    txtSalidaKilometros2.Text = values[1][2].ToString();
                    
                    txtDestinoLugar2.Text = values[1][4].ToString();
                    txtDestinoFecha2.Text = values[1][5].ToString();
                    txtDestinoKilometros2.Text = values[1][6].ToString();
                }
                catch (Exception) { }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            //Get Saldos
            range = $"{sheet}!B10:D11";
            request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;
            if (values != null && values.Count > 0)
            {
                CajaPesos.Text = values[0][0].ToString();
                CajaUruguayos.Text = values[0][1].ToString();
                CajaDolares.Text = values[0][2].ToString();
                SaldoPesos.Text = values[1][0].ToString();
                SaldoUruguayos.Text = values[1][1].ToString();
                SaldoDolares.Text = values[1][2].ToString();

            }
            else
            {
                Console.WriteLine("No data found.");
            }


            //Get ASIENTOS
            range = $"{sheet}!A14:C34";
            var asientos = new List<String[]> { };
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;

            dGridAsientos.Rows.Clear();

            if (values != null && values.Count > 0)
            {
                foreach (var value in values)
                {
                    dGridAsientos.Rows.Add(value[0], value[1], value[2]);

#pragma warning disable CS8601 // Possible null reference assignment.
                    String[] array = new string[] { value[0].ToString(), value[1].ToString(), value[2].ToString() };
#pragma warning restore CS8601 // Possible null reference assignment.
                    asientos.Add(array);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            var salidas_1 = new
            {
                lugar = txtSalidaLugar1.Text,
                fecha = txtSalidaFecha1.Text,
                kilometros = txtSalidaKilometros1.Text
            };

            var salidas_2 = new
            {
                lugar = txtSalidaLugar2.Text,
                fecha = txtSalidaFecha2.Text,
                kilometros = txtSalidaKilometros2.Text
            };

            var caja = new
            {
                pesos_argentinos = CajaPesos.Text,
                pesos_uruguayos = CajaUruguayos.Text,
                dolares = CajaDolares.Text
            };

            var saldo = new
            {
                saldo_argentinos = SaldoPesos.Text,
                saldo_uruguayos = SaldoUruguayos.Text,
                saldo_dolares = SaldoDolares.Text
            };

            var obj = new
            {
                viaje = txtViaje.Text,
                fecha = txtFecha.Text,
                chofer = txtChofer.Text,
                salidas_1,
                salidas_2,
                caja,
                saldo,
                asientos
            };


            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonString);


            /*var filePath = @".\Journey.json";
            var jsonData = System.IO.File.ReadAllText(filePath);
            if (!jsonData.Contains("viaje:" + txtViaje.Text))
                File.AppendAllText(filePath, "," + jsonString);*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        public string SearchSheetID()
        {
            var path = @".\trucks.json";
            List<Truck> trucks;
            string result = "";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    trucks = JsonConvert.DeserializeObject<List<Truck>>(json);
                    if (trucks != null)
                    {
                        foreach (Truck truck in trucks)
                        {
                            if (truck.patente == cBoxCamion.Text && truck.patente != null && truck.url_sheet != null)
                                result = truck.url_sheet;
                        }
                    }
                }
            }
            return result;
        }

        private void cBoxCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
