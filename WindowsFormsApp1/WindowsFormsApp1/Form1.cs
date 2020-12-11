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
                        varos = line[0],
                        iskola_tipus = line[1],
                        nem = line[2],
                        munkarend = line[3],
                        jegy = int.Parse(line[4]),
                        osszszazalek = int.Parse(line[5]),
                        osszpont = int.Parse(line[6]),
                    });

                }
            }
        }
    }
}
