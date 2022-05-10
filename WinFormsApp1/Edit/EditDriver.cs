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
    public partial class EditDriver : Form
    {
        public MainForm MyParent { get; set; }
        public EditDriver()
        {
            InitializeComponent();
            ReadDrivers();
        }

        List<Driver> drivers;

        public void ReadDrivers()
        {
            var path = @".\drivers.json";

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
                            cBoxID.Items.Add(driver.id);
                        }
                        cBoxID.SelectedIndex = 0;
                        RefreshTrucks();
                    }

                }
            }
        }

        public void RefreshTrucks()
        {
            foreach (Driver driver in drivers)
            {
                if (driver.id == cBoxID.SelectedIndex.ToString())
                {
                    txtDNI.Text = driver.dni;
                    txtNombre.Text = driver.nombre;
                    dNac.Value = DateTime.Parse(driver.fnac);

                    if (driver.status == true)
                        cBoxStatus.SelectedIndex = 1;
                    else
                        cBoxStatus.SelectedIndex = 0;

                }
            }
        }

        public class Driver
        {
            public string? id { get; set; }
            public string? nombre { get; set; }
            public string? dni { get; set; }
            public string? fnac { get; set; }
            public bool? status { get; set; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var path = @".\drivers.json";

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
                    List<Driver> ds = JsonConvert.DeserializeObject<List<Driver>>(json);

                    if (ds != null)
                    {
                        foreach (Driver d in ds)
                        {
                            if (d.id == cBoxID.Text)
                            {
                                d.id = cBoxID.Text;
                                d.nombre = txtNombre.Text;
                                d.dni = txtDNI.Text;
                                d.fnac = dNac.Value.ToString("yyyy-MM-dd");
                                d.status = status;
                            }
                        }

                        string newJson = JsonConvert.SerializeObject(ds);
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
