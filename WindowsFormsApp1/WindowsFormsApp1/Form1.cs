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
        List<string> megyek = new List<string>();
        List<string> iskolatipus = new List<string>();
        List<string> nem = new List<string>();
        List<string> kepzestipus = new List<string>();

        public Form1()
        {
            InitializeComponent();
            adatokbetolt();
            szazalekatlag();
            megyekmeghivasa();
            isktipusmeghivasa();
            nemmeghivasa();
            kepzestipusmeghivasa();

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
            ismervijellemzo.DataSource = null;
            if (ismerv.SelectedItem.ToString() == "Megye")
            {
                ismervijellemzo.DataSource = megyek;
            }

            if (ismerv.SelectedItem.ToString() == "Iskola típus")
            {
                ismervijellemzo.DataSource = iskolatipus;
            }

            if (ismerv.SelectedItem.ToString() == "Nem")
            {
                ismervijellemzo.DataSource = nem;
            }

            if (ismerv.SelectedItem.ToString() == "Képzés típusa")
            {
                ismervijellemzo.DataSource = kepzestipus;
            }
            ismervijellemzo.SelectedItem = null;
        }

        private void megyekmeghivasa()
        {
            using (StreamReader sr = new StreamReader("Adatok/Megyek.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    megyek.Add(line[0]);
                }
            }
        }

        private void isktipusmeghivasa()
        {
            using (StreamReader sr = new StreamReader("Adatok/Iskolatipusa.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    iskolatipus.Add(line[0]);
                }
            }
        }

        private void nemmeghivasa()
        {
            using (StreamReader sr = new StreamReader("Adatok/Nem.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    nem.Add(line[0]);
                }
            }
        }
        private void kepzestipusmeghivasa()
        {
            using (StreamReader sr = new StreamReader("Adatok/Kepzestipusa.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    kepzestipus.Add(line[0]);
                }
            }
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

        private void szazalekatlag()
        {
            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Megye")
            {
                chart3.Series["Series1"].Points.Clear();
                double atlagszazalek = (from x in Matek
                                where x.megye == ismervijellemzo.SelectedItem.ToString()
                                select x.osszszazalek).Average();
                chart3.Series["Series1"].Points.AddY(atlagszazalek);
                label4.Text = Math.Round(atlagszazalek, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Iskola típus")
            {
                chart3.Series["Series1"].Points.Clear();
                double atlagszazalek = (from x in Matek
                                where x.iskola_tipus == ismervijellemzo.SelectedItem.ToString()
                                select x.osszszazalek).Average();
                chart3.Series["Series1"].Points.AddY(atlagszazalek);
                label4.Text = Math.Round(atlagszazalek, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Nem")
            {
                chart3.Series["Series1"].Points.Clear();
                double atlagszazalek = (from x in Matek
                                where x.nem == ismervijellemzo.SelectedItem.ToString()
                                select x.osszszazalek).Average();
                chart3.Series["Series1"].Points.AddY(atlagszazalek);
                label4.Text = Math.Round(atlagszazalek, 2).ToString();
            }

            if (ismervijellemzo.SelectedItem != null && ismerv.SelectedItem.ToString() == "Képzés típusa")
            {
                chart3.Series["Series1"].Points.Clear();
                double atlagszazalek = (from x in Matek
                                where x.kepzestipusa == ismervijellemzo.SelectedItem.ToString()
                                select x.osszszazalek).Average();
                chart3.Series["Series1"].Points.AddY(atlagszazalek);
                label4.Text = Math.Round(atlagszazalek, 2).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            jegyatlag();
            szazalekatlag();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            chart2.Series["Series1"].Points.Clear();
            chart4.Series["Series1"].Points.Clear();
        }


    }
}
