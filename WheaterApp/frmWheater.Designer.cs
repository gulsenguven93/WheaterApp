namespace WheaterApp
{
    partial class frmWheater
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWheaterStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUpdateTime);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 17);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Şehir";
            // 
            // cbCity
            // 
            this.cbCity.DisplayMember = "title";
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(75, 17);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(174, 24);
            this.cbCity.TabIndex = 0;
            this.cbCity.ValueMember = "woeid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdResult);
            this.groupBox2.Location = new System.Drawing.Point(13, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(256, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(31, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "?";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToAddRows = false;
            this.grdResult.AllowUserToDeleteRows = false;
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmWheaterStateName,
            this.clmTemp,
            this.clmMinTemp,
            this.clmMaxTemp,
            this.clmWindSpeed});
            this.grdResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdResult.Location = new System.Drawing.Point(3, 18);
            this.grdResult.Name = "grdResult";
            this.grdResult.ReadOnly = true;
            this.grdResult.RowTemplate.Height = 24;
            this.grdResult.Size = new System.Drawing.Size(769, 343);
            this.grdResult.TabIndex = 0;
            // 
            // clmDate
            // 
            this.clmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 67;
            // 
            // clmWheaterStateName
            // 
            this.clmWheaterStateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmWheaterStateName.HeaderText = "State";
            this.clmWheaterStateName.Name = "clmWheaterStateName";
            this.clmWheaterStateName.ReadOnly = true;
            this.clmWheaterStateName.Width = 70;
            // 
            // clmTemp
            // 
            this.clmTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTemp.HeaderText = "Temp";
            this.clmTemp.Name = "clmTemp";
            this.clmTemp.ReadOnly = true;
            this.clmTemp.Width = 73;
            // 
            // clmMinTemp
            // 
            this.clmMinTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMinTemp.HeaderText = "Minimum Temp";
            this.clmMinTemp.Name = "clmMinTemp";
            this.clmMinTemp.ReadOnly = true;
            this.clmMinTemp.Width = 121;
            // 
            // clmMaxTemp
            // 
            this.clmMaxTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMaxTemp.HeaderText = "Maximum Temp";
            this.clmMaxTemp.Name = "clmMaxTemp";
            this.clmMaxTemp.ReadOnly = true;
            this.clmMaxTemp.Width = 124;
            // 
            // clmWindSpeed
            // 
            this.clmWindSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmWindSpeed.HeaderText = "Wind Speed";
            this.clmWindSpeed.Name = "clmWindSpeed";
            this.clmWindSpeed.ReadOnly = true;
            this.clmWindSpeed.Width = 105;
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.AutoSize = true;
            this.lblUpdateTime.Location = new System.Drawing.Point(307, 20);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(0, 17);
            this.lblUpdateTime.TabIndex = 3;
            // 
            // frmWheater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWheater";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmWheater_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWheaterStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindSpeed;
        private System.Windows.Forms.Label lblUpdateTime;
    }
}

