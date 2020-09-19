using StarWars.Models;
using System;
using System.Windows.Forms;

namespace StarWars
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      using (MyContext context = new MyContext())
      {
        // Create and save a new entity like starship

      }
    }
  }
}
