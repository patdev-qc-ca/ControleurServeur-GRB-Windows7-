using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;

namespace ControleurServeur
{
    public partial class PunchModifier : Form
    {
        public PunchModifier()
        {
            InitializeComponent();
        }

        private void PunchModifier_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 24; x++)
            {
                mskHeure.Items.Add(Droite($"0{x}:00", 5));
                mskHeure.Items.Add(Droite($"0{x}:15", 5));
                mskHeure.Items.Add(Droite($"0{x}:30", 5));
                mskHeure.Items.Add(Droite($"0{x}:45", 5));
            }
            mskHeure.Text = DateTime.Now.ToShortTimeString();
            mskHeure.SelectedIndex = (DateTime.Now.Hour + 1) * 4;
        }
    }
}
