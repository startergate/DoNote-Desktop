using System;
using System.Data;
using System.Windows.Forms;

namespace DoNote_Desktop
{
  public partial class NoteListForm : Form
  {
    private DataSet dataSet;
    
    public NoteListForm()
    {
      InitializeComponent();
    }

    private void NoteListForm_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=donote_beta;uid=world;pwd=1111";
      // TODO: Title 설정 - { User Name - DoNote }
    }
  }
}