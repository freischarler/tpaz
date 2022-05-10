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
    public partial class EditTrailer : Form
    {
        public MainForm MyParent { get; set; }
        public EditTrailer()
        {
            InitializeComponent();

            ReadTrailers();
        }


        List<Trailer> trailers;

        public void ReadTrailers()
        {

            var path = @".\trailers.json";

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
                            cBoxID.Items.Add(trailer.id);
                        }
                        cBoxID.SelectedIndex = 0;
                        RefreshTrucks();
                    }

                }
            }
        }

        public void RefreshTrucks()
        {
            foreach (Trailer trailer in trailers)
            {
                if (trailer.id == cBoxID.SelectedIndex.ToString())
                {
                    txtModelo.Text = trailer.modelo;
                    txtPatente.Text = trailer.patente;
                    dEngrasado.Value = DateTime.Parse(trailer.engrasado);
                    dService.Value = DateTime.Parse(trailer.service);
                    dVTV.Value = DateTime.Parse(trailer.vtv);
                    dRutas.Value = DateTime.Parse(trailer.rutas);
                    dSenasa.Value = DateTime.Parse(trailer.senasa);
                    dPoliza.Value = DateTime.Parse(trailer.poliza);

                    if (trailer.status == true)
                        cBoxStatus.SelectedIndex = 1;
                    else
                        cBoxStatus.SelectedIndex = 0;
                }
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var path = @".\trailers.json";

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
                    List<Trailer> ts = JsonConvert.DeserializeObject<List<Trailer>>(json);

                    if (ts != null)
                    {
                        foreach (Trailer t in ts)
                        {
                            if (t.id == cBoxID.Text)
                            {
                                t.modelo = txtModelo.Text;
                                t.patente = txtPatente.Text;
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
