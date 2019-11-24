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
      this.SuspendLayout();
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor =
        System.Drawing.Color.FromArgb(((int) (((byte) (61)))), ((int) (((byte) (65)))), ((int) (((byte) (77)))));
      this.ClientSize = new System.Drawing.Size(946, 685);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "LoginForm";
      this.Text = "Login - DoNote";
      this.ResumeLayout(false);
    }

    #endregion
  }
}