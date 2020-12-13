using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<erettsegik> Matek = new List<erettsegik>();

        public Form1()
        {
            InitializeComponent();
            adatokbetolt();

        }

        private void adatokbetolt()
        {
            using (StreamReader sr = new StreamReader("Adatok/adatok.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {

                    var line = sr.ReadLine().Split(';');
                    Matek.Add(new erettsegik()
                    {
                        megye = line[0],
                        iskola_tipus = line[1],
                        nem = line[2],
                        kepzestipusa = line[3],
                        jegy = int.Parse(line[4]),
                        osszszazalek = int.Parse(line[5]),
                        osszpont = int.Parse(line[6]),
                    });

                }
            }
        }

        private void ismerv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ismervijellemzo.Items.Clear();
            if (ismerv.SelectedItem.ToString() == "Megye")
            {
                using (StreamReader sr = new StreamReader("Adatok/Megyek.csv", Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        ismervijellemzo.Items.Add(line[0]);
                    }
                }

            }

            if (ismerv.SelectedItem.ToString() == "Iskola típus")
            {
                using (StreamReader sr = new StreamReader("Adatok/Iskolatipusa.csv", Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        ismervijellemzo.Items.Add(line[0]);
                    }
                }

            }

            if (ismerv.SelectedItem.ToString() == "Nem")
            {
                using (StreamReader sr = new StreamReader("Adatok/Nem.csv", Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        ismervijellemzo.Items.Add(line[0]);
                    }
                }

            }

            if (ismerv.SelectedItem.ToString() == "Képzés típusa")
            {
                using (StreamReader sr = new StreamReader("Adatok/Kepzestipusa.csv", Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        ismervijellemzo.Items.Add(line[0]);
                    }
                }

            }
            ismervijellemzo.SelectedIndex = 0;
        }


        private void jegyatlag()
        {
            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Megye")
            {
                chart1.Series["Series1"].Points.Clear();
                double atlag = (from x in Matek
                             where x.megye == ismervijellemzo.SelectedItem.ToString()
                             select x.jegy).Average();
                chart1.Series["Series1"].Points.AddY(atlag);
                label3.Text = Math.Round(atlag, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Iskola típus")
            {
                chart1.Series["Series1"].Points.Clear();
                double atlag = (from x in Matek
                                where x.iskola_tipus == ismervijellemzo.SelectedItem.ToString()
                                select x.jegy).Average();
                chart1.Series["Series1"].Points.AddY(atlag);
                label3.Text = Math.Round(atlag, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Nem")
            {
                chart1.Series["Series1"].Points.Clear();
                double atlag = (from x in Matek
                                where x.nem == ismervijellemzo.SelectedItem.ToString()
                                select x.jegy).Average();
                chart1.Series["Series1"].Points.AddY(atlag);
                label3.Text = Math.Round(atlag, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Képzés típusa")
            {
                chart1.Series["Series1"].Points.Clear();
                double atlag = (from x in Matek
                                where x.kepzestipusa == ismervijellemzo.SelectedItem.ToString()
                                select x.jegy).Average();
                chart1.Series["Series1"].Points.AddY(atlag);
                label3.Text = Math.Round(atlag, 2).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jegyatlag();
        }
    }
}
