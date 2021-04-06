namespace BD_Anisimov_Egor
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label1.Location = new System.Drawing.Point(280, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(632, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Талица со всеми входными и расчётными данными для кадлой передачи";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1224, 447);
			this.dataGridView1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(284, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сортировка \"a\" по\n  возрастанию";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(62, 33);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(176, 52);
			this.button2.TabIndex = 3;
			this.button2.Text = "Поиск по D1";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(105, 91);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(456, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(154, 50);
			this.button3.TabIndex = 5;
			this.button3.Text = "Сортивка \"L\" по\r\n возрастанию";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(616, 90);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(164, 50);
			this.button4.TabIndex = 6;
			this.button4.Text = "Сортировка \"a1\" по\r\n возрастанию";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(456, 33);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(154, 51);
			this.button5.TabIndex = 7;
			this.button5.Text = "Сортировка \"a (min)\" по\r\n возрастанию";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(284, 32);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(166, 52);
			this.button6.TabIndex = 8;
			this.button6.Text = "Сортировка \"v\" по возрастанию";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(616, 33);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(164, 51);
			this.button7.TabIndex = 9;
			this.button7.Text = "Сортировка \"D1\" по возрастанию";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1248, 663);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
	}
}