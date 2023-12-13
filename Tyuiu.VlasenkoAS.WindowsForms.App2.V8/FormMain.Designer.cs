namespace Tyuiu.VlasenkoAS.WindowsForms.App2.V8
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelDescriptionTask = new System.Windows.Forms.Label();
            this.textBoxValueStart = new System.Windows.Forms.TextBox();
            this.textBoxValueEnd = new System.Windows.Forms.TextBox();
            this.labelInscriptionValueStart = new System.Windows.Forms.Label();
            this.labelInscriptionValueEnd = new System.Windows.Forms.Label();
            this.chartVisualizeExpression = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxExpression = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisualizeExpression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpression)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(16, 609);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(747, 66);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Выполнить";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Controls.Add(this.labelDescriptionTask);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(779, 85);
            this.panelHeader.TabIndex = 1;
            // 
            // labelDescriptionTask
            // 
            this.labelDescriptionTask.AutoSize = true;
            this.labelDescriptionTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionTask.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDescriptionTask.Location = new System.Drawing.Point(16, 22);
            this.labelDescriptionTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionTask.Name = "labelDescriptionTask";
            this.labelDescriptionTask.Size = new System.Drawing.Size(495, 46);
            this.labelDescriptionTask.TabIndex = 3;
            this.labelDescriptionTask.Text = "Программа выводит график значений функции (производит \r\nтабулирование) f(x) на за" +
    "данном диапазоне.\r\n";
            // 
            // textBoxValueStart
            // 
            this.textBoxValueStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueStart.Location = new System.Drawing.Point(21, 555);
            this.textBoxValueStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValueStart.MaximumSize = new System.Drawing.Size(159, 29);
            this.textBoxValueStart.Name = "textBoxValueStart";
            this.textBoxValueStart.Size = new System.Drawing.Size(159, 34);
            this.textBoxValueStart.TabIndex = 2;
            this.textBoxValueStart.Text = "0";
            this.textBoxValueStart.Enter += new System.EventHandler(this.textBoxValueStart_Enter);
            this.textBoxValueStart.Leave += new System.EventHandler(this.textBoxValueStart_Leave);
            // 
            // textBoxValueEnd
            // 
            this.textBoxValueEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueEnd.Location = new System.Drawing.Point(201, 555);
            this.textBoxValueEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValueEnd.MaximumSize = new System.Drawing.Size(159, 29);
            this.textBoxValueEnd.Name = "textBoxValueEnd";
            this.textBoxValueEnd.Size = new System.Drawing.Size(159, 34);
            this.textBoxValueEnd.TabIndex = 2;
            this.textBoxValueEnd.Text = "0";
            this.textBoxValueEnd.Enter += new System.EventHandler(this.textBoxValueEnd_Enter);
            this.textBoxValueEnd.Leave += new System.EventHandler(this.textBoxValueEnd_Leave);
            // 
            // labelInscriptionValueStart
            // 
            this.labelInscriptionValueStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionValueStart.AutoSize = true;
            this.labelInscriptionValueStart.Location = new System.Drawing.Point(21, 535);
            this.labelInscriptionValueStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionValueStart.Name = "labelInscriptionValueStart";
            this.labelInscriptionValueStart.Size = new System.Drawing.Size(57, 16);
            this.labelInscriptionValueStart.TabIndex = 3;
            this.labelInscriptionValueStart.Text = "Начало";
            // 
            // labelInscriptionValueEnd
            // 
            this.labelInscriptionValueEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionValueEnd.AutoSize = true;
            this.labelInscriptionValueEnd.Location = new System.Drawing.Point(197, 535);
            this.labelInscriptionValueEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionValueEnd.Name = "labelInscriptionValueEnd";
            this.labelInscriptionValueEnd.Size = new System.Drawing.Size(47, 16);
            this.labelInscriptionValueEnd.TabIndex = 3;
            this.labelInscriptionValueEnd.Text = "Конец";
            // 
            // chartVisualizeExpression
            // 
            this.chartVisualizeExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartVisualizeExpression.BackColor = System.Drawing.SystemColors.Menu;
            this.chartVisualizeExpression.BorderlineColor = System.Drawing.SystemColors.Menu;
            chartArea1.Name = "ChartArea1";
            this.chartVisualizeExpression.ChartAreas.Add(chartArea1);
            this.chartVisualizeExpression.Location = new System.Drawing.Point(0, 112);
            this.chartVisualizeExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartVisualizeExpression.Name = "chartVisualizeExpression";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.chartVisualizeExpression.Series.Add(series1);
            this.chartVisualizeExpression.Size = new System.Drawing.Size(779, 395);
            this.chartVisualizeExpression.TabIndex = 4;
            // 
            // pictureBoxExpression
            // 
            this.pictureBoxExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExpression.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExpression.Image")));
            this.pictureBoxExpression.Location = new System.Drawing.Point(379, 514);
            this.pictureBoxExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxExpression.MaximumSize = new System.Drawing.Size(381, 76);
            this.pictureBoxExpression.Name = "pictureBoxExpression";
            this.pictureBoxExpression.Size = new System.Drawing.Size(381, 76);
            this.pictureBoxExpression.TabIndex = 4;
            this.pictureBoxExpression.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.pictureBoxExpression);
            this.Controls.Add(this.chartVisualizeExpression);
            this.Controls.Add(this.labelInscriptionValueEnd);
            this.Controls.Add(this.labelInscriptionValueStart);
            this.Controls.Add(this.textBoxValueEnd);
            this.Controls.Add(this.textBoxValueStart);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonCalculate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 728);
            this.Name = "FormMain";
            this.Text = "NTm-22-1 Vlasenko Andrei";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisualizeExpression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpression)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBoxValueStart;
        private System.Windows.Forms.TextBox textBoxValueEnd;
        private System.Windows.Forms.Label labelInscriptionValueStart;
        private System.Windows.Forms.Label labelInscriptionValueEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisualizeExpression ;
        private System.Windows.Forms.Label labelDescriptionTask;
        private System.Windows.Forms.PictureBox pictureBoxExpression;
    }
}

