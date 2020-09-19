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
        //var person = new People
        //{
        //  Name = "Alain",
        //  Created = DateTime.Now,
        //  Edited = DateTime.Now
        //};

        //context.Persons.Add(person);

        //var person2 = new People
        //{
        //  Name = "Mark",
        //  Created = DateTime.Now,
        //  Edited = DateTime.Now
        //};
        //context.Persons.Add(person2);

        var person3 = new People();
        context.Persons.Add(person3);

        context.SaveChanges();
      }
    }
  }
}
