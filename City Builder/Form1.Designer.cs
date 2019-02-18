namespace City_Builder {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Menu1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Menu1)).BeginInit();
			this.SuspendLayout();
			// 
			// Menu1
			// 
			this.Menu1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Menu1.Image = global::City_Builder.Properties.Resources.City;
			this.Menu1.Location = new System.Drawing.Point(-3, -3);
			this.Menu1.Name = "Menu1";
			this.Menu1.Size = new System.Drawing.Size(35, 36);
			this.Menu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Menu1.TabIndex = 1;
			this.Menu1.TabStop = false;
			this.Menu1.Click += new System.EventHandler(this.Menu1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(438, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = " q";
			this.label1.Click += new System.EventHandler(this.Form1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::City_Builder.Properties.Resources.Neon_Green_170726;
			this.ClientSize = new System.Drawing.Size(811, 400);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Menu1);
			this.Name = "Form1";
			this.Text = "x";
			this.Click += new System.EventHandler(this.Form1_Click);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.Menu1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox Menu1;
		private System.Windows.Forms.Label label1;
	}
}

