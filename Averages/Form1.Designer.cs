
namespace Averages
{
    partial class frmAverages
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
            this.btnAverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAverages
            // 
            this.btnAverages.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverages.Location = new System.Drawing.Point(128, 157);
            this.btnAverages.Name = "btnAverages";
            this.btnAverages.Size = new System.Drawing.Size(149, 37);
            this.btnAverages.TabIndex = 0;
            this.btnAverages.Text = "Calculate";
            this.btnAverages.UseVisualStyleBackColor = true;
            this.btnAverages.Click += new System.EventHandler(this.btnAverages_Click);
            // 
            // frmAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 376);
            this.Controls.Add(this.btnAverages);
            this.Name = "frmAverages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Averages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAverages;
    }
}

