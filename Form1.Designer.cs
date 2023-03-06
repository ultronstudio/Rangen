namespace Rangen
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblNumToGen = new System.Windows.Forms.Label();
            this.cboxNumToGen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumValGen = new System.Windows.Forms.TextBox();
            this.btnStartGen = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.tboxInterval = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.Black;
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppTitle.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(800, 146);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Rangen";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumToGen
            // 
            this.lblNumToGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumToGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumToGen.Location = new System.Drawing.Point(12, 156);
            this.lblNumToGen.Name = "lblNumToGen";
            this.lblNumToGen.Size = new System.Drawing.Size(201, 23);
            this.lblNumToGen.TabIndex = 1;
            this.lblNumToGen.Text = "Počet čísel k vygenerování:";
            this.lblNumToGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxNumToGen
            // 
            this.cboxNumToGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxNumToGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNumToGen.FormattingEnabled = true;
            this.cboxNumToGen.Location = new System.Drawing.Point(219, 158);
            this.cboxNumToGen.Name = "cboxNumToGen";
            this.cboxNumToGen.Size = new System.Drawing.Size(121, 21);
            this.cboxNumToGen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vygenerovaná čísla:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxNumValGen
            // 
            this.tboxNumValGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxNumValGen.Location = new System.Drawing.Point(177, 191);
            this.tboxNumValGen.Multiline = true;
            this.tboxNumValGen.Name = "tboxNumValGen";
            this.tboxNumValGen.ReadOnly = true;
            this.tboxNumValGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxNumValGen.Size = new System.Drawing.Size(611, 247);
            this.tboxNumValGen.TabIndex = 4;
            // 
            // btnStartGen
            // 
            this.btnStartGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartGen.Location = new System.Drawing.Point(16, 407);
            this.btnStartGen.Name = "btnStartGen";
            this.btnStartGen.Size = new System.Drawing.Size(148, 31);
            this.btnStartGen.TabIndex = 5;
            this.btnStartGen.Text = "Generuj";
            this.btnStartGen.UseVisualStyleBackColor = true;
            this.btnStartGen.Click += new System.EventHandler(this.btnStartGen_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInterval.Location = new System.Drawing.Point(577, 158);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(105, 23);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Interval čísel:";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxInterval
            // 
            this.tboxInterval.Location = new System.Drawing.Point(688, 158);
            this.tboxInterval.Name = "tboxInterval";
            this.tboxInterval.Size = new System.Drawing.Size(100, 20);
            this.tboxInterval.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.btnStartGen);
            this.Controls.Add(this.tboxNumValGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxNumToGen);
            this.Controls.Add(this.lblNumToGen);
            this.Controls.Add(this.lblAppTitle);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rangen";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblNumToGen;
        private System.Windows.Forms.ComboBox cboxNumToGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumValGen;
        private System.Windows.Forms.Button btnStartGen;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox tboxInterval;
    }
}

