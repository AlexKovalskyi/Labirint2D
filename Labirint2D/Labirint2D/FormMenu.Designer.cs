namespace Labirint2D
{
	partial class FormMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.button_start = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.box_sound = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button_start
			// 
			this.button_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_start.Location = new System.Drawing.Point(650, 509);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(113, 58);
			this.button_start.TabIndex = 0;
			this.button_start.Text = "Start Game";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// button_exit
			// 
			this.button_exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_exit.Location = new System.Drawing.Point(650, 12);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(113, 58);
			this.button_exit.TabIndex = 1;
			this.button_exit.Text = "Exit";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// box_sound
			// 
			this.box_sound.AutoSize = true;
			this.box_sound.BackColor = System.Drawing.Color.Transparent;
			this.box_sound.Checked = true;
			this.box_sound.CheckState = System.Windows.Forms.CheckState.Checked;
			this.box_sound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.box_sound.ForeColor = System.Drawing.Color.Red;
			this.box_sound.Location = new System.Drawing.Point(472, 547);
			this.box_sound.Name = "box_sound";
			this.box_sound.Size = new System.Drawing.Size(88, 20);
			this.box_sound.TabIndex = 2;
			this.box_sound.Text = "Sound On";
			this.box_sound.UseVisualStyleBackColor = false;
			this.box_sound.CheckedChanged += new System.EventHandler(this.box_sound_CheckedChanged);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Labirint2D.Properties.Resources.image_start;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(810, 603);
			this.Controls.Add(this.box_sound);
			this.Controls.Add(this.button_exit);
			this.Controls.Add(this.button_start);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Labirint2D";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.CheckBox box_sound;
	}
}

