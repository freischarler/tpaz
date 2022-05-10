using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using WinFormsApp1.Edit;
using Newtonsoft.Json;
using WinFormsApp1.New;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitPriorityList();
            InitJourneyList();

            StatusDate.ToolTipText = "DateTime: " + System.DateTime.Today.ToString();
            StatusDate.Text = System.DateTime.Today.ToLongDateString();
        }

        private class PriorityItem
        {
            public DateTime? date { get; set; }
            public string? id { get; set; }
            public string? type { get; set; }
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

        public class Journey
        {
            public string? id { get; set; }
            public string? chofer { get; set; }
            public string? camion { get; set; }
            public string? acoplado { get; set; }
            public Caja? caja { get; set; }
            public string? fecha { get; set; }
            public List<Asiento>? asientos { get; set; }
            public bool? status { get; set; }
        }

        public void InitJourneyList() {
            //open trails
            var path = @".\journeys.json";
            List<Journey> journeys;

            dataActiveJourney.Rows.Clear();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    journeys = JsonConvert.DeserializeObject<List<Journey>>(json);
                    if (journeys != null)
                    {
                        foreach (Journey journey in journeys)
                        {
                            if((bool)journey.status)
                                dataActiveJourney.Rows.Add(journey.id, journey.fecha, journey.camion, journey.acoplado, journey.chofer);
                            //listJourney.Items.Add(journey.id +" "+ journey.fecha + " "+  journey.camion + " " + journey.acoplado + " " + journey.chofer);

                        }
                    }
                }
            }
        }


        public void InitPriorityList()
        {
            //open trucks
            var path = @".\trucks.json";
            List<Truck> trucks;

            List<PriorityItem> priorityItems = new List<PriorityItem> { };

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
                            PriorityItem priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Engrasado";
                            priorityItem.date = DateTime.Parse(truck.engrasado);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Service";
                            priorityItem.date = DateTime.Parse(truck.service);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Service";
                            priorityItem.date = DateTime.Parse(truck.service);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "VTV";
                            priorityItem.date = DateTime.Parse(truck.vtv);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Rutas";
                            priorityItem.date = DateTime.Parse(truck.rutas);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Senaza";
                            priorityItem.date = DateTime.Parse(truck.senasa);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = truck.patente;
                            priorityItem.type = "Poliza";
                            priorityItem.date = DateTime.Parse(truck.poliza);
                            priorityItems.Add(priorityItem);
                        }
                    }
                }
            }

            //open trails
            path = @".\trails.json";
            List<Trailer> trails;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    trails = JsonConvert.DeserializeObject<List<Trailer>>(json);
                    if (trails != null)
                    {
                        foreach (Trailer trail in trails)
                        {
                            PriorityItem priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Engrasado";
                            priorityItem.date = DateTime.Parse(trail.engrasado);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Service";
                            priorityItem.date = DateTime.Parse(trail.service);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Service";
                            priorityItem.date = DateTime.Parse(trail.service);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "VTV";
                            priorityItem.date = DateTime.Parse(trail.vtv);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Rutas";
                            priorityItem.date = DateTime.Parse(trail.rutas);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Senaza";
                            priorityItem.date = DateTime.Parse(trail.senasa);
                            priorityItems.Add(priorityItem);

                            priorityItem = new PriorityItem { };
                            priorityItem.id = trail.patente;
                            priorityItem.type = "Poliza";
                            priorityItem.date = DateTime.Parse(trail.poliza);
                            priorityItems.Add(priorityItem);
                        }
                    }
                }
            }

            priorityItems.Sort((x, y) => DateTime.Compare((DateTime)x.date, (DateTime)y.date));

            listPriority.Items.Clear();
            foreach (PriorityItem priorityItem in priorityItems)
            {
                string d = ((DateTime)priorityItem.date).ToString("dd-MM-yyyy");
                listPriority.Items.Add( d + "           " + priorityItem.id + "      " + priorityItem.type);
            }
        }

        private void btnVerCamion_Click(object sender, EventArgs e)
        {
            ViewJourney viewJourney = new ViewJourney();
            viewJourney.ShowDialog();
        }

        private void viajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewJourney newJourneyForm = new NewJourney();
            newJourneyForm.MyParent = this; // this is a `MainForm` in this case
            newJourneyForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Sync");
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            System.Diagnostics.Debug.WriteLine("Sync");
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTruck NewtruckForm = new NewTruck();
            NewtruckForm.MyParent = this; // this is a `MainForm` in this case
            NewtruckForm.ShowDialog(); // Shows Form2
        }
        private void acopladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTrailer NewTrailerForm = new NewTrailer();
            NewTrailerForm.MyParent = this; // this is a `MainForm` in this case
            NewTrailerForm.ShowDialog(); 
        }

        private void camionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditTruck EditTruckForm = new EditTruck();
            EditTruckForm.MyParent = this; // this is a `MainForm` in this case
            EditTruckForm.ShowDialog();
        }

        private void acopladoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditTrailer EditTrailerForm = new EditTrailer();
            EditTrailerForm.MyParent = this; // this is a `MainForm` in this case
            EditTrailerForm.ShowDialog();
        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDriver NewDriverForm = new NewDriver();
            NewDriverForm.MyParent = this; // this is a `MainForm` in this case
            NewDriverForm.ShowDialog();
        }

        private void choferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditDriver EditDriverForm = new EditDriver();
            EditDriverForm.MyParent = this; // this is a `MainForm` in this case
            EditDriverForm.ShowDialog();
        }
    }

    
}