using AbstractClass_6.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          void MuzikaletleriCal(MuzikAletleri ma)
        {
            MessageBox.Show(ma.Cal());

        }

        private void btnGitarCal_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            
            MessageBox.Show(gtr.Cal());
        }

        private void btnKemanCal_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            MessageBox.Show(kmn.Cal());
        }

        private void btnBateriCal_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            btr.Ses = "çalıyor...";
            
           
            
            MessageBox.Show(btr.Cal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
