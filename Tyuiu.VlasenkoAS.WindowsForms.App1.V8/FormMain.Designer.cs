namespace Tyuiu.VlasenkoAS.WindowsForms.App1.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelInscriptionValueX = new System.Windows.Forms.Label();
            this.labelInscriptionSelectExpression = new System.Windows.Forms.Label();
            this.labelInscriptionResult = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelDescriptionTask = new System.Windows.Forms.Label();
            this.textBoxValueX = new System.Windows.Forms.TextBox();
            this.textBoxValueY = new System.Windows.Forms.TextBox();
            this.textBoxValueExpression = new System.Windows.Forms.TextBox();
            this.radioButtonFirstExpression = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondExpression = new System.Windows.Forms.RadioButton();
            this.labelInscriptionValueY = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(16, 608);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(480, 68);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Вычисление";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelInscriptionValueX
            // 
            this.labelInscriptionValueX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionValueX.AutoSize = true;
            this.labelInscriptionValueX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInscriptionValueX.Location = new System.Drawing.Point(12, 102);
            this.labelInscriptionValueX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionValueX.Name = "labelInscriptionValueX";
            this.labelInscriptionValueX.Size = new System.Drawing.Size(101, 23);
            this.labelInscriptionValueX.TabIndex = 1;
            this.labelInscriptionValueX.Text = "Значение X";
            // 
            // labelInscriptionSelectExpression
            // 
            this.labelInscriptionSelectExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionSelectExpression.AutoSize = true;
            this.labelInscriptionSelectExpression.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInscriptionSelectExpression.Location = new System.Drawing.Point(12, 294);
            this.labelInscriptionSelectExpression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionSelectExpression.Name = "labelInscriptionSelectExpression";
            this.labelInscriptionSelectExpression.Size = new System.Drawing.Size(183, 23);
            this.labelInscriptionSelectExpression.TabIndex = 1;
            this.labelInscriptionSelectExpression.Text = "Выберите выражение";
            // 
            // labelInscriptionResult
            // 
            this.labelInscriptionResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionResult.AutoSize = true;
            this.labelInscriptionResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInscriptionResult.Location = new System.Drawing.Point(16, 518);
            this.labelInscriptionResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionResult.Name = "labelInscriptionResult";
            this.labelInscriptionResult.Size = new System.Drawing.Size(86, 23);
            this.labelInscriptionResult.TabIndex = 1;
            this.labelInscriptionResult.Text = "Результат";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Controls.Add(this.labelDescriptionTask);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(512, 85);
            this.panelHeader.TabIndex = 2;
            // 
            // labelDescriptionTask
            // 
            this.labelDescriptionTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescriptionTask.AutoSize = true;
            this.labelDescriptionTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionTask.ForeColor = System.Drawing.Color.White;
            this.labelDescriptionTask.Location = new System.Drawing.Point(16, 22);
            this.labelDescriptionTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionTask.Name = "labelDescriptionTask";
            this.labelDescriptionTask.Size = new System.Drawing.Size(337, 46);
            this.labelDescriptionTask.TabIndex = 1;
            this.labelDescriptionTask.Text = "Программа запрашивает данные X и Y, и\r\nпо ним вычисляет значения выражений\r\n";
            // 
            // textBoxValueX
            // 
            this.textBoxValueX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueX.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxValueX.Location = new System.Drawing.Point(16, 127);
            this.textBoxValueX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValueX.Name = "textBoxValueX";
            this.textBoxValueX.Size = new System.Drawing.Size(479, 34);
            this.textBoxValueX.TabIndex = 3;
            this.textBoxValueX.Text = "0.00";
            this.textBoxValueX.Enter += new System.EventHandler(this.textBoxValueX_Enter);
            this.textBoxValueX.Leave += new System.EventHandler(this.textBoxValueX_Leave);
            // 
            // textBoxValueY
            // 
            this.textBoxValueY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueY.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxValueY.Location = new System.Drawing.Point(16, 218);
            this.textBoxValueY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValueY.Name = "textBoxValueY";
            this.textBoxValueY.Size = new System.Drawing.Size(479, 34);
            this.textBoxValueY.TabIndex = 3;
            this.textBoxValueY.Text = "0.00";
            this.textBoxValueY.Enter += new System.EventHandler(this.textBoxValueY_Enter);
            this.textBoxValueY.Leave += new System.EventHandler(this.textBoxValueY_Leave);
            // 
            // textBoxValueExpression
            // 
            this.textBoxValueExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueExpression.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxValueExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValueExpression.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueExpression.Location = new System.Drawing.Point(20, 543);
            this.textBoxValueExpression.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValueExpression.Name = "textBoxValueExpression";
            this.textBoxValueExpression.ReadOnly = true;
            this.textBoxValueExpression.Size = new System.Drawing.Size(480, 35);
            this.textBoxValueExpression.TabIndex = 3;
            this.textBoxValueExpression.Text = "0.00";
            // 
            // radioButtonFirstExpression
            // 
            this.radioButtonFirstExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFirstExpression.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFirstExpression.AutoSize = true;
            this.radioButtonFirstExpression.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonFirstExpression.Image")));
            this.radioButtonFirstExpression.Location = new System.Drawing.Point(16, 320);
            this.radioButtonFirstExpression.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFirstExpression.Name = "radioButtonFirstExpression";
            this.radioButtonFirstExpression.Size = new System.Drawing.Size(176, 76);
            this.radioButtonFirstExpression.TabIndex = 4;
            this.radioButtonFirstExpression.TabStop = true;
            this.radioButtonFirstExpression.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondExpression
            // 
            this.radioButtonSecondExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSecondExpression.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSecondExpression.AutoSize = true;
            this.radioButtonSecondExpression.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonSecondExpression.Image")));
            this.radioButtonSecondExpression.Location = new System.Drawing.Point(260, 320);
            this.radioButtonSecondExpression.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSecondExpression.Name = "radioButtonSecondExpression";
            this.radioButtonSecondExpression.Size = new System.Drawing.Size(177, 77);
            this.radioButtonSecondExpression.TabIndex = 4;
            this.radioButtonSecondExpression.TabStop = true;
            this.radioButtonSecondExpression.Text = "\r\n";
            this.radioButtonSecondExpression.UseVisualStyleBackColor = true;
            // 
            // labelInscriptionValueY
            // 
            this.labelInscriptionValueY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscriptionValueY.AutoSize = true;
            this.labelInscriptionValueY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInscriptionValueY.Location = new System.Drawing.Point(12, 193);
            this.labelInscriptionValueY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscriptionValueY.Name = "labelInscriptionValueY";
            this.labelInscriptionValueY.Size = new System.Drawing.Size(100, 23);
            this.labelInscriptionValueY.TabIndex = 1;
            this.labelInscriptionValueY.Text = "Значение Y";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(512, 690);
            this.Controls.Add(this.radioButtonSecondExpression);
            this.Controls.Add(this.radioButtonFirstExpression);
            this.Controls.Add(this.textBoxValueExpression);
            this.Controls.Add(this.textBoxValueY);
            this.Controls.Add(this.textBoxValueX);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelInscriptionResult);
            this.Controls.Add(this.labelInscriptionValueY);
            this.Controls.Add(this.labelInscriptionSelectExpression);
            this.Controls.Add(this.labelInscriptionValueX);
            this.Controls.Add(this.buttonCalculate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(530, 737);
            this.Name = "FormMain";
            this.Text = "NTm-22-1 Vlasenko Andrei";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelInscriptionValueX;
        private System.Windows.Forms.Label labelInscriptionSelectExpression;
        private System.Windows.Forms.Label labelInscriptionResult;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBoxValueX;
        private System.Windows.Forms.TextBox textBoxValueY;
        private System.Windows.Forms.TextBox textBoxValueExpression;
        private System.Windows.Forms.RadioButton radioButtonFirstExpression;
        private System.Windows.Forms.RadioButton radioButtonSecondExpression;
        private System.Windows.Forms.Label labelDescriptionTask;
        private System.Windows.Forms.Label labelInscriptionValueY;
    }
}

