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

namespace WinFormsApp1.New
{
    public partial class NewDriver : Form
    {
        public MainForm MyParent { get; set; }
        public NewDriver()
        {
            InitializeComponent();

            InitId();
        }

        public class Driver
        {
            public string? id { get; set; }
            public string? nombre { get; set; }
            public string? dni { get; set; }
            public string? fnac { get; set; }
            public bool? status { get; set; }
        }

        private void InitId()
        {
            var path = @".\drivers.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    var ds = JsonConvert.DeserializeObject<List<Driver>>(json);
                    if (ds != null)
                        txtID.Text = ds.Count.ToString();
                }
            }
            else
            {
                txtID.Text = "0";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var path = @".\drivers.json";

            Driver driver = new()
            {
                id = txtID.Text,
                nombre = txtNombre.Text,
                dni = txtDNI.Text,
                fnac = dNac.Value.ToString("yyyy-MM-dd"),
                status = true
            };

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (json != null)
                {
                    List<Driver> ds = JsonConvert.DeserializeObject<List<Driver>>(json);

                    bool c = true;
                    if (ds != null)
                    {
                        foreach (Driver d in ds)
                        {
                            if (d.id == txtID.Text)
                                c = false;
                        }

                        if (c)
                        {
                            ds.Add(driver);
                            string newJson = JsonConvert.SerializeObject(ds);

                            //json = JsonConvert.SerializeObject(newJson);
                            File.WriteAllText(path, newJson);
                        }
                    }
                }
            }
            else
            {
                List<Driver> ds = new() { };
                ds.Add(driver);
                string newJson = JsonConvert.SerializeObject(ds);

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
