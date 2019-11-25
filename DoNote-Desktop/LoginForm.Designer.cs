using System.ComponentModel;

namespace DoNote_Desktop
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxID = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.buttonLoginProcess = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxID
      // 
      this.textBoxID.Location = new System.Drawing.Point(371, 210);
      this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxID.Name = "textBoxID";
      this.textBoxID.Size = new System.Drawing.Size(193, 23);
      this.textBoxID.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(371, 239);
      this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(193, 23);
      this.textBox2.TabIndex = 1;
      // 
      // buttonLoginProcess
      // 
      this.buttonLoginProcess.Location = new System.Drawing.Point(338, 268);
      this.buttonLoginProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonLoginProcess.Name = "buttonLoginProcess";
      this.buttonLoginProcess.Size = new System.Drawing.Size(226, 21);
      this.buttonLoginProcess.TabIndex = 2;
      this.buttonLoginProcess.Text = "로그인";
      this.buttonLoginProcess.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(371, 172);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(161, 26);
      this.label1.TabIndex = 3;
      this.label1.Text = "DoNote";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(338, 209);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 22);
      this.label2.TabIndex = 4;
      this.label2.Text = "ID";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(338, 240);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 22);
      this.label3.TabIndex = 5;
      this.label3.Text = "PW";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor =
        System.Drawing.Color.FromArgb(((int) (((byte) (61)))), ((int) (((byte) (65)))), ((int) (((byte) (77)))));
      this.ClientSize = new System.Drawing.Size(946, 685);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonLoginProcess);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBoxID);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "LoginForm";
      this.Text = "Login - DoNote";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonLoginProcess;
    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}