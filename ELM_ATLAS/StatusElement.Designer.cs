namespace ELM_ATLAS
{
    partial class StatusElement
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusElement));
            check = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            errorPb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPb).BeginInit();
            SuspendLayout();
            // 
            // check
            // 
            check.BackColor = Color.White;
            check.BackgroundImage = (Image)resources.GetObject("check.BackgroundImage");
            check.Location = new Point(80, 33);
            check.Name = "check";
            check.Size = new Size(35, 36);
            check.TabIndex = 0;
            check.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(52, 56, 93);
            label2.Location = new Point(881, 30);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // errorPb
            // 
            errorPb.BackColor = Color.White;
            errorPb.BackgroundImage = (Image)resources.GetObject("errorPb.BackgroundImage");
            errorPb.Location = new Point(80, 34);
            errorPb.Name = "errorPb";
            errorPb.Size = new Size(35, 35);
            errorPb.TabIndex = 3;
            errorPb.TabStop = false;
            // 
            // StatusElement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(errorPb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(check);
            Name = "StatusElement";
            Size = new Size(2029, 98);
            ((System.ComponentModel.ISupportInitialize)check).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox check;
        private Label label1;
        private Label label2;
        private PictureBox errorPb;
    }
}
