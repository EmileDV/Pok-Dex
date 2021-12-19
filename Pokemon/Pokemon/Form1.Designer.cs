namespace Pokemon
{
    partial class Pokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Favorites = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pokemon.Properties.Resources.fondo;
            this.panel1.Controls.Add(this.Favorites);
            this.panel1.Controls.Add(this.previous);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 578);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.Transparent;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.ForeColor = System.Drawing.Color.Blue;
            this.previous.Location = new System.Drawing.Point(279, 83);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(116, 35);
            this.previous.TabIndex = 3;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.ForeColor = System.Drawing.Color.Blue;
            this.next.Location = new System.Drawing.Point(453, 83);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(116, 35);
            this.next.TabIndex = 2;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pokemon.Properties.Resources.logo_pokemon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Favorites
            // 
            this.Favorites.BackColor = System.Drawing.Color.Transparent;
            this.Favorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favorites.ForeColor = System.Drawing.Color.Blue;
            this.Favorites.Location = new System.Drawing.Point(279, 26);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(116, 35);
            this.Favorites.TabIndex = 4;
            this.Favorites.Text = "Favorites";
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click);
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 578);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pokemon";
            this.Text = "Pokémon";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button next;
        private Button previous;
        private Button Favorites;
    }
}