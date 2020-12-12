namespace ACDGridSharp
{
    partial class mainWind
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.opnFileBtn = new System.Windows.Forms.Button();
            this.savFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(500, 500);
            this.dataGridView.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(505, 1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 500);
            this.vScrollBar1.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(2, 504);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(500, 25);
            this.hScrollBar1.TabIndex = 2;
            // 
            // opnFileBtn
            // 
            this.opnFileBtn.Location = new System.Drawing.Point(571, 145);
            this.opnFileBtn.Name = "opnFileBtn";
            this.opnFileBtn.Size = new System.Drawing.Size(200, 50);
            this.opnFileBtn.TabIndex = 3;
            this.opnFileBtn.Text = "Open File";
            this.opnFileBtn.UseVisualStyleBackColor = true;
            this.opnFileBtn.Click += new System.EventHandler(this.opnFileBtn_Click);
            // 
            // savFileBtn
            // 
            this.savFileBtn.Location = new System.Drawing.Point(571, 289);
            this.savFileBtn.Name = "savFileBtn";
            this.savFileBtn.Size = new System.Drawing.Size(200, 50);
            this.savFileBtn.TabIndex = 4;
            this.savFileBtn.Text = "Save File";
            this.savFileBtn.UseVisualStyleBackColor = true;
            this.savFileBtn.Click += new System.EventHandler(this.savFileBtn_Click);
            // 
            // mainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.savFileBtn);
            this.Controls.Add(this.opnFileBtn);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView);
            this.Name = "mainWind";
            this.Text = "ADCLabsGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button opnFileBtn;
        private System.Windows.Forms.Button savFileBtn;
    }
}

