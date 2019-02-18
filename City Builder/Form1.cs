using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static City_Builder.Properties.Resources;


namespace City_Builder {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		
		bool itemInHand = false;

		Buildings building = new Buildings();


		private void Menu1_Click( object sender, EventArgs e ) {
			building = new Buildings();
			building.picture.Name = "building";
			building.picture.Size = new Size(20, 20);
			//building.picture.Location = Form1.MousePosition;
			building.picture.Image = City;
			building.picture.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Controls.Add(building.picture);
			
			itemInHand = true;
			label1.Text = "He clicked on the build.";
			//building.Click += new EventHandler();

		}



		private void Form1_MouseMove( object sender, MouseEventArgs e ) {
			if(itemInHand==true) {
				building.picture.Location = new Point(e.X, e.Y);
				label1.Text = "He moved while holding.";
				
			}
			if(itemInHand != true) {
				label1.Text = "He moved while not holding.";
			}
			
		}
	
		private void Form1_Click( object sender, EventArgs e ) {
			label1.Text = "He clicked.";
			if(itemInHand==true) {
				itemInHand = false;
				label1.Text = "He clicked.";
			}
			
		}

		
	}
}
