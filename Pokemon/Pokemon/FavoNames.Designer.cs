namespace Pokemon
{
    partial class FavoNames
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
            this.Name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name.ForeColor = System.Drawing.Color.Blue;
            this.Name.Location = new System.Drawing.Point(3, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(144, 41);
            this.Name.TabIndex = 0;
            this.Name.Text = "button1";
            this.Name.UseVisualStyleBackColor = false;
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // FavoNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Name);
            //this.Name = "FavoNames";
            this.Size = new System.Drawing.Size(150, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Name;
    }
}
