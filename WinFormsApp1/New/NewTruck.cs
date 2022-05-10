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

namespace WinFormsApp1
{
    public partial class NewTruck : Form
    {
        public MainForm MyParent { get; set; }
        public NewTruck()
        {
            InitializeComponent();

            InitId();
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

        private void InitId()
        {
            var path = @".\trucks.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    var ts = JsonConvert.DeserializeObject<List<Truck>>(json);
                    if(ts != null)
                        txtId.Text=ts.Count.ToString();
                }
            }
            else
            {
                txtId.Text = "0";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var path = @".\trucks.json";

            Truck truck = new()
            {
                id = txtId.Text,
                modelo = txtModelo.Text,
                patente = txtPatente.Text,
                url_sheet = txtURLSheet.Text,
                engrasado = dEngrasado.Value.ToString("yyyy-MM-dd"),
            service = dService.Value.ToString("yyyy-MM-dd"),
                vtv = dVTV.Value.ToString("yyyy-MM-dd"),
                rutas = dRutas.Value.ToString("yyyy-MM-dd"),
                senasa = dSenasa.Value.ToString("yyyy-MM-dd"),
                poliza = dPoliza.Value.ToString("yyyy-MM-dd"),
                status = true
            };

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if(json != null)
                {
                    List<Truck> ts = JsonConvert.DeserializeObject<List<Truck>>(json);

                    bool c = true;
                    if (ts != null)
                    {
                        foreach (Truck t in ts)
                        {
                            if (t.id == txtId.Text)
                                c = false;
                        }

                        if (c)
                        {
                            ts.Add(truck);
                            string newJson = JsonConvert.SerializeObject(ts);

                            //json = JsonConvert.SerializeObject(newJson);
                            File.WriteAllText(path, newJson);
                        }
                    }
                }
            }
            else
            {
                List<Truck> ts = new() { };
                ts.Add(truck);
                string newJson = JsonConvert.SerializeObject(ts);

                //var json = JsonConvert.SerializeObject(newJson);
                File.WriteAllText(path, newJson);
            }
            this.MyParent.InitPriorityList();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
