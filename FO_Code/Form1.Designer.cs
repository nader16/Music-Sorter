namespace FO_Code
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.property_Combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.view_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.select_record = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Property: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Songs You Want to Sort:\r\n";
            // 
            // property_Combobox
            // 
            this.property_Combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.property_Combobox.FormattingEnabled = true;
            this.property_Combobox.Items.AddRange(new object[] {
            "Artist",
            "Album",
            "Title",
            "Year",
            "Genre ",
            "Duration"});
            this.property_Combobox.Location = new System.Drawing.Point(556, 26);
            this.property_Combobox.Name = "property_Combobox";
            this.property_Combobox.Size = new System.Drawing.Size(121, 24);
            this.property_Combobox.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select_record});
            this.dataGridView.Location = new System.Drawing.Point(52, 121);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1272, 416);
            this.dataGridView.TabIndex = 3;
            // 
            // view_button
            // 
            this.view_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.view_button.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_button.Location = new System.Drawing.Point(362, 593);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(155, 35);
            this.view_button.TabIndex = 4;
            this.view_button.Text = "View All Files";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sort_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sort_button.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_button.Location = new System.Drawing.Point(795, 593);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(94, 35);
            this.sort_button.TabIndex = 5;
            this.sort_button.Text = "Sort";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // select_record
            // 
            this.select_record.FalseValue = "False";
            this.select_record.HeaderText = "Select";
            this.select_record.IndeterminateValue = "Null";
            this.select_record.Name = "select_record";
            this.select_record.TrueValue = "True";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 667);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.property_Combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox property_Combobox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select_record;
    }
}

