namespace StarWars
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageFilm = new System.Windows.Forms.TabPage();
      this.tabPageVehicle = new System.Windows.Forms.TabPage();
      this.tabPageStarship = new System.Windows.Forms.TabPage();
      this.tabPageTransport = new System.Windows.Forms.TabPage();
      this.tabPageSpecies = new System.Windows.Forms.TabPage();
      this.tabPagePlanet = new System.Windows.Forms.TabPage();
      this.tabPagePeople = new System.Windows.Forms.TabPage();
      this.tabControlMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageFilm);
      this.tabControlMain.Controls.Add(this.tabPageVehicle);
      this.tabControlMain.Controls.Add(this.tabPageStarship);
      this.tabControlMain.Controls.Add(this.tabPageTransport);
      this.tabControlMain.Controls.Add(this.tabPageSpecies);
      this.tabControlMain.Controls.Add(this.tabPagePlanet);
      this.tabControlMain.Controls.Add(this.tabPagePeople);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 0);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(800, 450);
      this.tabControlMain.TabIndex = 0;
      // 
      // tabPageFilm
      // 
      this.tabPageFilm.Location = new System.Drawing.Point(4, 22);
      this.tabPageFilm.Name = "tabPageFilm";
      this.tabPageFilm.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageFilm.Size = new System.Drawing.Size(792, 424);
      this.tabPageFilm.TabIndex = 0;
      this.tabPageFilm.Text = "Film";
      this.tabPageFilm.UseVisualStyleBackColor = true;
      // 
      // tabPageVehicle
      // 
      this.tabPageVehicle.Location = new System.Drawing.Point(4, 22);
      this.tabPageVehicle.Name = "tabPageVehicle";
      this.tabPageVehicle.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageVehicle.Size = new System.Drawing.Size(792, 424);
      this.tabPageVehicle.TabIndex = 1;
      this.tabPageVehicle.Text = "Vehicle";
      this.tabPageVehicle.UseVisualStyleBackColor = true;
      // 
      // tabPageStarship
      // 
      this.tabPageStarship.Location = new System.Drawing.Point(4, 22);
      this.tabPageStarship.Name = "tabPageStarship";
      this.tabPageStarship.Size = new System.Drawing.Size(792, 424);
      this.tabPageStarship.TabIndex = 2;
      this.tabPageStarship.Text = "Starship";
      this.tabPageStarship.UseVisualStyleBackColor = true;
      // 
      // tabPageTransport
      // 
      this.tabPageTransport.Location = new System.Drawing.Point(4, 22);
      this.tabPageTransport.Name = "tabPageTransport";
      this.tabPageTransport.Size = new System.Drawing.Size(792, 424);
      this.tabPageTransport.TabIndex = 3;
      this.tabPageTransport.Text = "Transport";
      this.tabPageTransport.UseVisualStyleBackColor = true;
      // 
      // tabPageSpecies
      // 
      this.tabPageSpecies.Location = new System.Drawing.Point(4, 22);
      this.tabPageSpecies.Name = "tabPageSpecies";
      this.tabPageSpecies.Size = new System.Drawing.Size(792, 424);
      this.tabPageSpecies.TabIndex = 4;
      this.tabPageSpecies.Text = "Species";
      this.tabPageSpecies.UseVisualStyleBackColor = true;
      // 
      // tabPagePlanet
      // 
      this.tabPagePlanet.Location = new System.Drawing.Point(4, 22);
      this.tabPagePlanet.Name = "tabPagePlanet";
      this.tabPagePlanet.Size = new System.Drawing.Size(792, 424);
      this.tabPagePlanet.TabIndex = 5;
      this.tabPagePlanet.Text = "Planet";
      this.tabPagePlanet.UseVisualStyleBackColor = true;
      // 
      // tabPagePeople
      // 
      this.tabPagePeople.Location = new System.Drawing.Point(4, 22);
      this.tabPagePeople.Name = "tabPagePeople";
      this.tabPagePeople.Size = new System.Drawing.Size(792, 424);
      this.tabPagePeople.TabIndex = 6;
      this.tabPagePeople.Text = "People";
      this.tabPagePeople.UseVisualStyleBackColor = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControlMain);
      this.Name = "FormMain";
      this.Text = "Star Wars";
      this.tabControlMain.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageFilm;
    private System.Windows.Forms.TabPage tabPageVehicle;
    private System.Windows.Forms.TabPage tabPageStarship;
    private System.Windows.Forms.TabPage tabPageTransport;
    private System.Windows.Forms.TabPage tabPageSpecies;
    private System.Windows.Forms.TabPage tabPagePlanet;
    private System.Windows.Forms.TabPage tabPagePeople;
  }
}

