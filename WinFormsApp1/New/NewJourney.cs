using Newtonsoft.Json;
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

namespace WinFormsApp1.New
{
    public partial class NewJourney : Form
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Google Sheets API .NET Quickstart";

        string sheetID = "1AwVknEEAYR8EGrJ_Xg1Ygxc8eh_1zyiHxhb1_zYZmk0";

        public MainForm MyParent { get; set; }
        public NewJourney()
        {
            InitializeComponent();

            InitConfig();
        }

        public class Caja
        {
            public Activo? activo { get; set; }
            public Saldo? saldo { get; set; }
        }

        public class Activo
        {
            public string? peso_arg { get; set; }
            public string? peso_uru { get; set; }
            public string? dolar { get; set; }
        }

        public class Saldo
        {
            public string? peso_arg { get; set; }
            public string? peso_uru { get; set; }
            public string? dolar { get; set; }
        }

        public class Asiento
        {
            public string? tipo { get; set; }
            public string? moneda { get; set; }
            public string? valor { get; set; }
            public string? comentarios { get; set; }
        }

        public class Ida
        {
            public string? salida { get; set; }
            public string? destino { get; set; }
            public string? fecha_salida { get; set; }
            public string? fecha_destino { get; set; }
            public string? kilometros_salida { get; set; }
            public string? kilometros_destino { get; set; }
        }

        public class Vuelta
        {
            public string? salida { get; set; }
            public string? destino { get; set; }
            public string? fecha_salida { get; set; }
            public string? fecha_destino { get; set; }
            public string? kilometros_salida { get; set; }
            public string? kilometros_destino { get; set; }
        }

        public class Destinos
        {
            public Ida? ida { get; set; }
            public Vuelta? vuelta { get; set; } 
        }

        public class Journey
        {
            public string? id { get; set; }
            public string? chofer { get; set; }
            public string? camion { get; set; }
            public string? acoplado { get; set; }
            public Destinos? destinos { get; set; }
            public Caja? caja { get; set; }
            public string? fecha { get; set; }
            public List<Asiento>? asientos { get; set; }
            public bool? status { get; set; }
        }

        public class Trailer
        {
            public string? id { get; set; }
            public string? modelo { get; set; }
            public string? patente { get; set; }
            public string? engrasado { get; set; }
            public string? service { get; set; }
            public string? vtv { get; set; }
            public string? rutas { get; set; }
            public string? senasa { get; set; }
            public string? poliza { get; set; }
            public bool? status { get; set; }
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
        public class Driver
        {
            public string? id { get; set; }
            public string? nombre { get; set; }
            public string? dni { get; set; }
            public string? fnac { get; set; }
            public bool? status { get; set; }
        }
        
        public void InitConfig()
        {
            var path = @".\journeys.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    var js = JsonConvert.DeserializeObject<List<Journey>>(json);
                    if (js != null)
                        txtID.Text = js.Count.ToString();
                }
            }
            else
            {
                txtID.Text = "0";
            }

            path = @".\drivers.json";
            List<Driver> drivers;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
                    if (drivers != null)
                    {
                        foreach (Driver driver in drivers)
                        {
                            if ((bool)driver.status)
                                cBoxChofer.Items.Add(driver.nombre);
                        }
                        cBoxChofer.SelectedIndex = 0;
                    }

                }
            }

            path = @".\trucks.json";
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

            path = @".\trailers.json";
            List<Trailer> trailers;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    trailers = JsonConvert.DeserializeObject<List<Trailer>>(json);
                    if (trailers != null)
                    {
                        foreach (Trailer trailer in trailers)
                        {
                            if ((bool)trailer.status)
                                cBoxAcoplado.Items.Add(trailer.patente);
                        }
                        cBoxAcoplado.SelectedIndex = 0;
                    }
                }
            }
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
                            if (truck.patente == cBoxCamion.Text && truck.patente!= null && truck.url_sheet != null)
                                result = truck.url_sheet;
                        }
                    }
                }
            }
            return result;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveSheet();
            
            DeleteSheet();

            var path = @".\journeys.json";

            Activo activo = new()
            {
                peso_arg = txtARG.Text,
                peso_uru = txtURU.Text,
                dolar = txtDOLAR.Text
            };

            Saldo saldo = new()
            {
                peso_arg = "0",
                peso_uru = "0",
                dolar = "0",
            };

            Caja caja = new()
            {
                activo = activo,
                saldo = saldo,
            };

            List<Asiento> asiento = new() { };

            Journey journey = new()
            {
                id = txtID.Text,
                chofer = cBoxChofer.Text,
                camion = cBoxCamion.Text,
                acoplado = cBoxAcoplado.Text,
                caja = caja,
                fecha = dFecha.Value.ToString("yyyy-MM-dd"),
                asientos = asiento,
                status = true
            };

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    List<Journey> js = JsonConvert.DeserializeObject<List<Journey>>(json);

                    bool c = true;
                    if (js != null)
                    {
                        foreach (Journey t in js)
                        {
                            if (t.id == txtID.Text)
                                c = false;
                        }

                        if (c)
                        {
                            js.Add(journey);
                            string newJson = JsonConvert.SerializeObject(js);
                            File.WriteAllText(path, newJson);
                        }
                    }
                }
            }
            else
            {
                List<Journey> js = new() { };
                js.Add(journey);
                string newJson = JsonConvert.SerializeObject(js);
                File.WriteAllText(path, newJson);
            }
            this.MyParent.InitJourneyList();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MyParent.InitPriorityList();
            this.Close();
        }



        private void SaveSheet()
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
            sheetID=SearchSheetID();

            String spreadsheetId = sheetID;

            String sheet = "Hoja 1";
            //Get VIAJE FECHA CHOFER
            var range = $"{sheet}!B1:F3";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            var response = request.Execute();
            IList<IList<object>> values = response.Values;

            Journey journey = new();

            journey.status = false;

            if (values != null && values.Count > 0)
            {
                try
                {
                    journey.id = values[0][0].ToString();
                    journey.fecha = values[1][0].ToString();
                    journey.chofer = values[2][0].ToString();
                    journey.camion = values[1][3].ToString();
                    journey.acoplado = values[2][3].ToString();
                }
                catch (Exception) { }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            //Get SALIDA DESTINO
            range = $"{sheet}!B6:H7";
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;

            journey.destinos = new();
            journey.destinos.ida = new();
            journey.destinos.vuelta = new();
            if (values != null && values.Count > 0)
            {
                try
                {
                    journey.destinos.ida.salida = values[0][0].ToString();
                    journey.destinos.ida.fecha_salida = values[0][1].ToString();
                    journey.destinos.ida.kilometros_salida = values[0][2].ToString();
                    journey.destinos.ida.destino = values[0][4].ToString();
                    journey.destinos.ida.fecha_destino = values[0][5].ToString();
                    journey.destinos.ida.kilometros_destino = values[0][6].ToString();

                    journey.destinos.vuelta.salida = values[0][0].ToString();
                    journey.destinos.vuelta.fecha_salida = values[0][1].ToString();
                    journey.destinos.vuelta.kilometros_salida = values[0][2].ToString();
                    journey.destinos.vuelta.destino = values[0][4].ToString();
                    journey.destinos.vuelta.fecha_destino = values[0][5].ToString();
                    journey.destinos.vuelta.kilometros_destino = values[0][6].ToString();
                }
                catch (Exception) { }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            //Get Saldos
            range = $"{sheet}!B10:D11";
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;

            journey.caja = new();
            journey.caja.activo = new();
            journey.caja.saldo = new();
            if (values != null && values.Count > 0)
            {
                try
                {
                    journey.caja.activo.peso_arg = values[0][0].ToString();
                    journey.caja.activo.peso_uru = values[0][1].ToString();
                    journey.caja.activo.dolar = values[0][2].ToString();


                    journey.caja.saldo.peso_arg = values[1][0].ToString();
                    journey.caja.saldo.peso_uru = values[1][1].ToString();
                    journey.caja.saldo.dolar = values[1][2].ToString();
                }
                catch (Exception) { }
            }
            else
            {
                Console.WriteLine("No data found.");
            }


            //Get ASIENTOS
            range = $"{sheet}!A14:E34";
            //var asientos = new List<String[]> { };
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            response = request.Execute();
            values = response.Values;

            journey.asientos = new() { }; 

            if (values != null && values.Count > 0 && values.Count < 4)
            {
                foreach (var value in values)
                {
                    Asiento asiento = new();

                    if (value[0] != null) asiento.tipo = value[0].ToString();
                    if (value[1] != null) asiento.moneda = value[1].ToString();
                    if (value[2] != null) asiento.valor = value[2].ToString();

                    journey.asientos.Add(asiento);
                }
            }
            if (values != null && values.Count == 4)
            {
                foreach (var value in values)
                {
                    Asiento asiento = new();

                    if (value[0] != null) asiento.tipo = value[0].ToString();
                    if (value[1] != null) asiento.moneda = value[1].ToString();
                    if (value[2] != null) asiento.valor = value[2].ToString();
                    if (value[3] != null) asiento.comentarios = value[3].ToString();

                    journey.asientos.Add(asiento);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            var path = @".\journeys.json";

            if (File.Exists(path) && journey.id != "-1")
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    List<Journey> js = JsonConvert.DeserializeObject<List<Journey>>(json);

                    bool c = true;
                    if (js != null)
                    {
                        foreach (Journey t in js)
                        {
                            if (t.id == journey.id)
                                c = false;
                        }

                        if (c)
                        {
                            js.Add(journey);
                            string newJson = JsonConvert.SerializeObject(js);
                            File.WriteAllText(path, newJson);
                        }
                        else
                        {
                            List<Journey> jsf = new();

                            foreach (Journey t in js)
                            {
                                if (t.id != journey.id)
                                    jsf.Add(t);
                                else
                                    jsf.Add(journey);
                            }

                            string newJson = JsonConvert.SerializeObject(jsf);
                            File.WriteAllText(path, newJson);

                        }
                    }
                }
            }
            else if (journey.id != "-1")
            {
                List<Journey> js = new() { };
                js.Add(journey);
                string newJson = JsonConvert.SerializeObject(js);
                File.WriteAllText(path, newJson);
            }
        }
        private void DeleteSheet()
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

            sheetID = SearchSheetID();
            // Define request parameters.
            String spreadsheetId = sheetID;

            String sheet = "Hoja 1";

            var range = $"{sheet}!B1:F1";
            var valueRange = new ValueRange();
            valueRange.MajorDimension = "ROWS";//"ROWS";//COLUMNS

            var oblist = new List<object>() { txtID.Text };
            valueRange.Values = new List<IList<object>> { oblist };

            var appendRequest = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            var appendReponse = appendRequest.Execute();


            range = $"{sheet}!B2:C3";
            valueRange = new ValueRange();
            valueRange.MajorDimension = "COLUMNS";//"ROWS";//COLUMNS

            oblist = new List<object>() { dFecha.Value.ToString("dd/MM/yyyy "), cBoxChofer.Text };
            valueRange.Values = new List<IList<object>> { oblist };

            appendRequest = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            appendReponse = appendRequest.Execute();


            range = $"{sheet}!E2:F3";
            valueRange = new ValueRange();
            valueRange.MajorDimension = "COLUMNS";//"ROWS";//COLUMNS

            oblist = new List<object>() { cBoxCamion.Text, cBoxAcoplado.Text };
            valueRange.Values = new List<IList<object>> { oblist };

            appendRequest = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            appendReponse = appendRequest.Execute();

            //delete salida
            range = $"{sheet}!B6:D7";
            range = $"{sheet}!F6:H7";
            var requestBody = new ClearValuesRequest();

            var deleteRequest = service.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
            var deleteReponse = deleteRequest.Execute();

            //delete destino
            range = $"{sheet}!F6:H7";
            requestBody = new ClearValuesRequest();

            deleteRequest = service.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
            deleteReponse = deleteRequest.Execute();

            //update caja
            range = $"{sheet}!B10:D10";
            valueRange = new ValueRange();
            valueRange.MajorDimension = "ROWS";//"ROWS";//COLUMNS

            oblist = new List<object>() { Int32.Parse(txtARG.Text), Int32.Parse(txtURU.Text), Int32.Parse(txtDOLAR.Text) };
            valueRange.Values = new List<IList<object>> { oblist };

            appendRequest = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            appendReponse = appendRequest.Execute();

            //delete asientos
            range = $"{sheet}!A14:E34";
            requestBody = new ClearValuesRequest();

            deleteRequest = service.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
            deleteReponse = deleteRequest.Execute();
        }

        private void cBoxCamion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
