namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.buttonFool = new System.Windows.Forms.Button();
			this.buttonNotFool = new System.Windows.Forms.Button();
			this.labelShow = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonRetry = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonFool
			// 
			this.buttonFool.BackColor = System.Drawing.Color.Firebrick;
			this.buttonFool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFool.Location = new System.Drawing.Point(122, 115);
			this.buttonFool.Name = "buttonFool";
			this.buttonFool.Size = new System.Drawing.Size(185, 75);
			this.buttonFool.TabIndex = 0;
			this.buttonFool.Text = "Fool";
			this.buttonFool.UseVisualStyleBackColor = false;
			this.buttonFool.Click += new System.EventHandler(this.buttonFool_Click);
			// 
			// buttonNotFool
			// 
			this.buttonNotFool.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonNotFool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNotFool.Location = new System.Drawing.Point(489, 115);
			this.buttonNotFool.Name = "buttonNotFool";
			this.buttonNotFool.Size = new System.Drawing.Size(185, 75);
			this.buttonNotFool.TabIndex = 1;
			this.buttonNotFool.Text = "Not Fool";
			this.buttonNotFool.UseVisualStyleBackColor = false;
			this.buttonNotFool.Click += new System.EventHandler(this.buttonNotFool_Click);
			this.buttonNotFool.MouseEnter += new System.EventHandler(this.buttonNotFoolEnter);
			// 
			// labelShow
			// 
			this.labelShow.AutoSize = true;
			this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelShow.Location = new System.Drawing.Point(284, 64);
			this.labelShow.Name = "labelShow";
			this.labelShow.Size = new System.Drawing.Size(148, 31);
			this.labelShow.TabIndex = 2;
			this.labelShow.Text = "labelShow";
			this.labelShow.Visible = false;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.Firebrick;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExit.Location = new System.Drawing.Point(651, 298);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(121, 45);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Visible = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonRetry
			// 
			this.buttonRetry.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRetry.Location = new System.Drawing.Point(12, 298);
			this.buttonRetry.Name = "buttonRetry";
			this.buttonRetry.Size = new System.Drawing.Size(121, 45);
			this.buttonRetry.TabIndex = 4;
			this.buttonRetry.Text = "Retry";
			this.buttonRetry.UseVisualStyleBackColor = false;
			this.buttonRetry.Visible = false;
			this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 355);
			this.Controls.Add(this.buttonRetry);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.labelShow);
			this.Controls.Add(this.buttonNotFool);
			this.Controls.Add(this.buttonFool);
			this.Name = "Form1";
			this.Text = "Fool Game";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonFool;
		private System.Windows.Forms.Button buttonNotFool;
		private System.Windows.Forms.Label labelShow;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonRetry;
	}
}

