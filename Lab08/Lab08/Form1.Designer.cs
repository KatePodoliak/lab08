namespace Lab08
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.btnDoSelect = new System.Windows.Forms.Button();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.textBoxTableCmd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxON = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDoJoin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTable2 = new System.Windows.Forms.TextBox();
            this.textBoxTable1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFieldsJoin = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDoCmd = new System.Windows.Forms.Button();
            this.textBoxValuesCmd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFields = new System.Windows.Forms.TextBox();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // dgwData
            // 
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(11, 12);
            this.dgwData.Name = "dgwData";
            this.dgwData.Size = new System.Drawing.Size(618, 316);
            this.dgwData.TabIndex = 2;
            // 
            // btnDoSelect
            // 
            this.btnDoSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDoSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDoSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoSelect.ForeColor = System.Drawing.Color.White;
            this.btnDoSelect.Location = new System.Drawing.Point(59, 72);
            this.btnDoSelect.Name = "btnDoSelect";
            this.btnDoSelect.Size = new System.Drawing.Size(100, 28);
            this.btnDoSelect.TabIndex = 3;
            this.btnDoSelect.Text = "Do";
            this.btnDoSelect.UseVisualStyleBackColor = false;
            this.btnDoSelect.Click += new System.EventHandler(this.btnDoSelect_Click);
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(59, 28);
            this.textBoxTable.Multiline = true;
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(128, 20);
            this.textBoxTable.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoSelect);
            this.groupBox1.Controls.Add(this.textBoxTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(635, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 119);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT";
            // 
            // textBoxSet
            // 
            this.textBoxSet.Location = new System.Drawing.Point(287, 24);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(127, 23);
            this.textBoxSet.TabIndex = 8;
            // 
            // textBoxTableCmd
            // 
            this.textBoxTableCmd.Location = new System.Drawing.Point(87, 60);
            this.textBoxTableCmd.Name = "textBoxTableCmd";
            this.textBoxTableCmd.Size = new System.Drawing.Size(127, 23);
            this.textBoxTableCmd.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxON);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnDoJoin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxTable2);
            this.groupBox2.Controls.Add(this.textBoxTable1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxFieldsJoin);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 151);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JOIN";
            // 
            // textBoxON
            // 
            this.textBoxON.Location = new System.Drawing.Point(88, 114);
            this.textBoxON.Name = "textBoxON";
            this.textBoxON.Size = new System.Drawing.Size(530, 23);
            this.textBoxON.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "ON:";
            // 
            // btnDoJoin
            // 
            this.btnDoJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoJoin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoJoin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDoJoin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDoJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoJoin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoJoin.ForeColor = System.Drawing.Color.White;
            this.btnDoJoin.Location = new System.Drawing.Point(683, 54);
            this.btnDoJoin.Name = "btnDoJoin";
            this.btnDoJoin.Size = new System.Drawing.Size(100, 28);
            this.btnDoJoin.TabIndex = 14;
            this.btnDoJoin.Text = "Do";
            this.btnDoJoin.UseVisualStyleBackColor = false;
            this.btnDoJoin.Click += new System.EventHandler(this.btnDoJoin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(221, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Table 2:";
            // 
            // textBoxTable2
            // 
            this.textBoxTable2.Location = new System.Drawing.Point(286, 82);
            this.textBoxTable2.Name = "textBoxTable2";
            this.textBoxTable2.Size = new System.Drawing.Size(127, 23);
            this.textBoxTable2.TabIndex = 22;
            // 
            // textBoxTable1
            // 
            this.textBoxTable1.Location = new System.Drawing.Point(88, 82);
            this.textBoxTable1.Name = "textBoxTable1";
            this.textBoxTable1.Size = new System.Drawing.Size(127, 23);
            this.textBoxTable1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Table 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fields:";
            // 
            // textBoxFieldsJoin
            // 
            this.textBoxFieldsJoin.Location = new System.Drawing.Point(88, 22);
            this.textBoxFieldsJoin.Multiline = true;
            this.textBoxFieldsJoin.Name = "textBoxFieldsJoin";
            this.textBoxFieldsJoin.Size = new System.Drawing.Size(530, 54);
            this.textBoxFieldsJoin.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDoCmd);
            this.groupBox3.Controls.Add(this.textBoxValuesCmd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxFields);
            this.groupBox3.Controls.Add(this.textBoxWhere);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbCommand);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSet);
            this.groupBox3.Controls.Add(this.textBoxTableCmd);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 491);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 158);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation (INSERT/UPDATE/DELETE)";
            // 
            // btnDoCmd
            // 
            this.btnDoCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoCmd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoCmd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDoCmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDoCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoCmd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoCmd.ForeColor = System.Drawing.Color.White;
            this.btnDoCmd.Location = new System.Drawing.Point(104, 101);
            this.btnDoCmd.Name = "btnDoCmd";
            this.btnDoCmd.Size = new System.Drawing.Size(100, 28);
            this.btnDoCmd.TabIndex = 15;
            this.btnDoCmd.Text = "Do";
            this.btnDoCmd.UseVisualStyleBackColor = false;
            this.btnDoCmd.Click += new System.EventHandler(this.btnDoCmd_Click);
            // 
            // textBoxValuesCmd
            // 
            this.textBoxValuesCmd.Location = new System.Drawing.Point(287, 61);
            this.textBoxValuesCmd.Multiline = true;
            this.textBoxValuesCmd.Name = "textBoxValuesCmd";
            this.textBoxValuesCmd.Size = new System.Drawing.Size(523, 68);
            this.textBoxValuesCmd.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(220, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Values:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(220, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fields:";
            // 
            // textBoxFields
            // 
            this.textBoxFields.Location = new System.Drawing.Point(287, 24);
            this.textBoxFields.Name = "textBoxFields";
            this.textBoxFields.Size = new System.Drawing.Size(525, 23);
            this.textBoxFields.TabIndex = 17;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(287, 60);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(127, 23);
            this.textBoxWhere.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Command:";
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Location = new System.Drawing.Point(87, 24);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(127, 24);
            this.cmbCommand.TabIndex = 12;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "From:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(641, 193);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 16);
            this.labelInfo.TabIndex = 14;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(635, 141);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(741, 141);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.btnDisconnect.TabIndex = 16;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 661);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Laboratory work 8";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnDoSelect;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSet;
        private System.Windows.Forms.TextBox textBoxTableCmd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoJoin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValuesCmd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFields;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Button btnDoCmd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textBoxON;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTable2;
        private System.Windows.Forms.TextBox textBoxTable1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFieldsJoin;
    }
}

