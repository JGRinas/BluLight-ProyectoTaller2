﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2022.CapaPresentacion
{
    public partial class FormOpen : Form
    {
        public FormOpen()
        {
            InitializeComponent();
        }

        private void FormOpen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            bunifuCircleProgress1.Value += 1;
            if (bunifuCircleProgress1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                FormSesion formSesion = new FormSesion();
                formSesion.Show();
                this.Close();
                
            }
        }
    }
}
