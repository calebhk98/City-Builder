using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Builder {
	class Buildings {

		
		public PictureBox picture = new PictureBox {
			Name = "",// The name
			Tag = "",//No tag needed
			Size = new Size(20, 20),//Keep it small
			Image = Properties.Resources.City,//The image of a small picart of a city
			//Click+=delegate(object sender, EventArgs args ) { Clicked(); }
		};//The picture and most of the info
		public bool Holding = true;//Is it held?


		public void Clicked( object sender, EventArgs e ) {
			Console.WriteLine("This is running after being clicked");
			Holding = false;
		}	//This should run when the picture is clicked



		/*
			public event EventHandler<MouseEventArgs> Click;
			protected void OnClick( MouseEventArgs e ) {
				Console.WriteLine("Hey, this is in OnClick");
				EventHandler<MouseEventArgs> handler = Click;

				if(handler != null) {
					Console.WriteLine("Hey, this is in Handler");
					handler(this, e);

				}
			}

			internal void CheckIfClicked( MouseEventArgs e ) {
				if(true) {
					Console.WriteLine("Hey, this is in Check if Clicked");
					OnClick(e);

				}
			}
			*/
		

	}
}
