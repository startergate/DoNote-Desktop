﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNote_Desktop
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var login = new LoginForm {Location = this.Location, StartPosition = this.StartPosition};
      
      login.Show();
      this.Hide();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: Some SID session checks using fs
    }
  }
}