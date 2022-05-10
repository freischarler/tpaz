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

namespace WinFormsApp1.Edit
{
    public partial class EditTruck : Form
    {
        public MainForm MyParent { get; set; }
        public EditTruck()
        {
            InitializeComponent();
            ReadTrucks();
        }

        List<Truck> trucks;

        public void ReadTrucks()
        {

            var path = @".\trucks.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    trucks = JsonConvert.DeserializeObject<List<Truck>>(json);
                    if (trucks != null)
                    {
                        foreach(Truck truck in trucks)
                        {
                            cBoxID.Items.Add(truck.id);
                        }
                        cBoxID.SelectedIndex = 0;
                        RefreshTrucks();
                    }

                }
            }
        }

        public void RefreshTrucks()
        {
            foreach (Truck truck in trucks)
            {
                if(truck.id == cBoxID.SelectedIndex.ToString())
                {
                    txtModelo.Text = truck.modelo;
                    txtPatente.Text = truck.patente;
                    txtURLSheet.Text = truck.url_sheet;
                    dEngrasado.Value = DateTime.Parse(truck.engrasado);
                    dService.Value = DateTime.Parse(truck.service);
                    dVTV.Value = DateTime.Parse(truck.vtv);
                    dRutas.Value = DateTime.Parse(truck.rutas);
                    dSenasa.Value = DateTime.Parse(truck.senasa);    
                    dPoliza.Value = DateTime.Parse(truck.poliza);    

                    if(truck.status == true)
                        cBoxStatus.SelectedIndex = 1;
                    else
                        cBoxStatus.SelectedIndex = 0;

                }
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var path = @".\trucks.json";

            bool status = false; ;
            if (cBoxStatus.SelectedIndex == 1)
                status = true;
            else
                status = false;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    List<Truck> ts = JsonConvert.DeserializeObject<List<Truck>>(json);

                    if (ts != null)
                    {
                        foreach (Truck t in ts)
                        {
                            if (t.id == cBoxID.Text)
                            {
                                t.modelo = txtModelo.Text;
                                t.patente = txtPatente.Text;
                                t.url_sheet = txtURLSheet.Text;
                                t.engrasado = dEngrasado.Value.ToString("yyyy-MM-dd");
                                t.service = dService.Value.ToString("yyyy-MM-dd");
                                t.vtv = dVTV.Value.ToString("yyyy-MM-dd");
                                t.rutas = dRutas.Value.ToString("yyyy-MM-dd");
                                t.senasa = dSenasa.Value.ToString("yyyy-MM-dd");
                                t.poliza = dPoliza.Value.ToString("yyyy-MM-dd");
                                t.status = status;
                            }
                        }

                        string newJson = JsonConvert.SerializeObject(ts);
                        File.WriteAllText(path, newJson);
                    }
                }
            }
            this.MyParent.InitPriorityList();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTrucks();
        }
    }
}
