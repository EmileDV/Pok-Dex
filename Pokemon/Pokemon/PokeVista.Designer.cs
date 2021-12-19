namespace Pokemon
{
    partial class PokeVista
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.images = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // images
            // 
            this.images.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.images.Location = new System.Drawing.Point(16, 21);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(98, 101);
            this.images.TabIndex = 1;
            this.images.TabStop = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.Location = new System.Drawing.Point(26, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 28);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            this.name.UseVisualStyleBackColor = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // PokeVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.images);
            this.Name = "PokeVista";
            this.Size = new System.Drawing.Size(131, 159);
            this.Load += new System.EventHandler(this.PokeVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox images;
        private Button name;
    }
}
