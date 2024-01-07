namespace DigitalClock
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			dateTimeDE = new Button();
			dateTimeUK = new Button();
			dateTimeUSA = new Button();
			dateTimeHR = new Button();
			panelhr1 = new panelHR();
			panelde1 = new panelDE();
			paneluk1 = new panelUK();
			panelusa1 = new panelUSA();
			lblTime = new Label();
			lblDate = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(dateTimeDE);
			panel1.Controls.Add(dateTimeUK);
			panel1.Controls.Add(dateTimeUSA);
			panel1.Controls.Add(dateTimeHR);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 450);
			panel1.TabIndex = 0;
			// 
			// dateTimeDE
			// 
			dateTimeDE.Image = Properties.Resources.Flag_Germany;
			dateTimeDE.Location = new Point(50, 308);
			dateTimeDE.Name = "dateTimeDE";
			dateTimeDE.Size = new Size(100, 50);
			dateTimeDE.TabIndex = 3;
			dateTimeDE.UseVisualStyleBackColor = true;
			dateTimeDE.Click += dateTimeDE_Click;
			// 
			// dateTimeUK
			// 
			dateTimeUK.Image = Properties.Resources.Flag_of_the_United_Kingdom;
			dateTimeUK.Location = new Point(50, 215);
			dateTimeUK.Name = "dateTimeUK";
			dateTimeUK.Size = new Size(100, 50);
			dateTimeUK.TabIndex = 2;
			dateTimeUK.UseVisualStyleBackColor = true;
			dateTimeUK.Click += dateTimeUK_Click;
			// 
			// dateTimeUSA
			// 
			dateTimeUSA.Image = Properties.Resources.Flag_of_the_United_States_svg;
			dateTimeUSA.Location = new Point(50, 128);
			dateTimeUSA.Name = "dateTimeUSA";
			dateTimeUSA.Size = new Size(100, 50);
			dateTimeUSA.TabIndex = 1;
			dateTimeUSA.UseVisualStyleBackColor = true;
			dateTimeUSA.Click += dateTimeUSA_Click;
			// 
			// dateTimeHR
			// 
			dateTimeHR.Image = Properties.Resources.Flag_of_Croatia_svg;
			dateTimeHR.Location = new Point(50, 43);
			dateTimeHR.Name = "dateTimeHR";
			dateTimeHR.Size = new Size(100, 50);
			dateTimeHR.TabIndex = 0;
			dateTimeHR.UseVisualStyleBackColor = true;
			dateTimeHR.Click += dateTimeHR_Click;
			// 
			// panelhr1
			// 
			panelhr1.BackColor = Color.White;
			panelhr1.Location = new Point(193, 0);
			panelhr1.Name = "panelhr1";
			panelhr1.Size = new Size(607, 450);
			panelhr1.TabIndex = 1;
			// 
			// panelde1
			// 
			panelde1.BackColor = Color.Gold;
			panelde1.Location = new Point(193, 0);
			panelde1.Name = "panelde1";
			panelde1.Size = new Size(607, 450);
			panelde1.TabIndex = 2;
			// 
			// paneluk1
			// 
			paneluk1.BackColor = Color.Blue;
			paneluk1.Location = new Point(193, 0);
			paneluk1.Name = "paneluk1";
			paneluk1.Size = new Size(607, 450);
			paneluk1.TabIndex = 3;
			// 
			// panelusa1
			// 
			panelusa1.BackColor = Color.Red;
			panelusa1.Location = new Point(193, 0);
			panelusa1.Name = "panelusa1";
			panelusa1.Size = new Size(607, 450);
			panelusa1.TabIndex = 4;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.BackColor = Color.Transparent;
			lblTime.Font = new Font("Candara", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblTime.Location = new Point(360, 150);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(205, 59);
			lblTime.TabIndex = 5;
			lblTime.Text = "00:00:00";
			lblTime.Click += lblTime_Click;
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.BackColor = Color.Transparent;
			lblDate.Font = new Font("Candara", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblDate.Location = new Point(360, 215);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(281, 68);
			lblDate.TabIndex = 6;
			lblDate.Text = "dd.mm.yyyy.";
			lblDate.TextAlign = ContentAlignment.MiddleCenter;
			lblDate.UseCompatibleTextRendering = true;
			lblDate.Click += lblDate_Click;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblDate);
			Controls.Add(lblTime);
			Controls.Add(panelusa1);
			Controls.Add(paneluk1);
			Controls.Add(panelde1);
			Controls.Add(panelhr1);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button dateTimeHR;
		private Button dateTimeUSA;
		private Button dateTimeUK;
		private Button dateTimeDE;
		private panelHR panelhr1;
		private panelDE panelde1;
		private panelUK paneluk1;
		private panelUSA panelusa1;
		private Label lblTime;
		private Label lblDate;
		private System.Windows.Forms.Timer timer1;
	}
}