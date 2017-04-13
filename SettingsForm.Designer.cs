namespace GUI
{
    partial class SettingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nodes_gridview = new System.Windows.Forms.DataGridView();
            this.Node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.end_checkbox = new System.Windows.Forms.CheckBox();
            this.nodes_Radio = new System.Windows.Forms.RadioButton();
            this.transition_Radio = new System.Windows.Forms.RadioButton();
            this.transitions_gridview = new System.Windows.Forms.DataGridView();
            this.transition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitions_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // nodes_gridview
            // 
            this.nodes_gridview.AllowUserToAddRows = false;
            this.nodes_gridview.AllowUserToDeleteRows = false;
            this.nodes_gridview.AllowUserToResizeColumns = false;
            this.nodes_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nodes_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.nodes_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodes_gridview.BackgroundColor = System.Drawing.Color.OldLace;
            this.nodes_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodes_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.nodes_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodes_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Node});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nodes_gridview.DefaultCellStyle = dataGridViewCellStyle33;
            this.nodes_gridview.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.nodes_gridview.Location = new System.Drawing.Point(12, 12);
            this.nodes_gridview.Name = "nodes_gridview";
            this.nodes_gridview.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodes_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.nodes_gridview.RowHeadersVisible = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.nodes_gridview.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.nodes_gridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodes_gridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nodes_gridview.Size = new System.Drawing.Size(176, 229);
            this.nodes_gridview.TabIndex = 2;
            // 
            // Node
            // 
            this.Node.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Node.HeaderText = "Nodes";
            this.Node.Name = "Node";
            this.Node.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(194, 105);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(275, 105);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(194, 164);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(194, 135);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(156, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // end_checkbox
            // 
            this.end_checkbox.AutoSize = true;
            this.end_checkbox.Location = new System.Drawing.Point(275, 81);
            this.end_checkbox.Name = "end_checkbox";
            this.end_checkbox.Size = new System.Drawing.Size(84, 17);
            this.end_checkbox.TabIndex = 8;
            this.end_checkbox.Text = "End node..?";
            this.end_checkbox.UseVisualStyleBackColor = true;
            // 
            // nodes_Radio
            // 
            this.nodes_Radio.AutoSize = true;
            this.nodes_Radio.Checked = true;
            this.nodes_Radio.Location = new System.Drawing.Point(194, 224);
            this.nodes_Radio.Name = "nodes_Radio";
            this.nodes_Radio.Size = new System.Drawing.Size(56, 17);
            this.nodes_Radio.TabIndex = 9;
            this.nodes_Radio.TabStop = true;
            this.nodes_Radio.Text = "Nodes";
            this.nodes_Radio.UseVisualStyleBackColor = true;
            this.nodes_Radio.CheckedChanged += new System.EventHandler(this.nodes_Radio_CheckedChanged);
            // 
            // transition_Radio
            // 
            this.transition_Radio.AutoSize = true;
            this.transition_Radio.Location = new System.Drawing.Point(274, 224);
            this.transition_Radio.Name = "transition_Radio";
            this.transition_Radio.Size = new System.Drawing.Size(76, 17);
            this.transition_Radio.TabIndex = 10;
            this.transition_Radio.Text = "Transitions";
            this.transition_Radio.UseVisualStyleBackColor = true;
            this.transition_Radio.CheckedChanged += new System.EventHandler(this.transition_Radio_CheckedChanged);
            // 
            // transitions_gridview
            // 
            this.transitions_gridview.AllowUserToAddRows = false;
            this.transitions_gridview.AllowUserToDeleteRows = false;
            this.transitions_gridview.AllowUserToResizeColumns = false;
            this.transitions_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transitions_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.transitions_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transitions_gridview.BackgroundColor = System.Drawing.Color.OldLace;
            this.transitions_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitions_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.transitions_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transitions_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transition});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transitions_gridview.DefaultCellStyle = dataGridViewCellStyle38;
            this.transitions_gridview.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.transitions_gridview.Location = new System.Drawing.Point(12, 12);
            this.transitions_gridview.Name = "transitions_gridview";
            this.transitions_gridview.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitions_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.transitions_gridview.RowHeadersVisible = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.transitions_gridview.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.transitions_gridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitions_gridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transitions_gridview.Size = new System.Drawing.Size(176, 229);
            this.transitions_gridview.TabIndex = 11;
            this.transitions_gridview.Visible = false;
            // 
            // transition
            // 
            this.transition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transition.HeaderText = "Transitions";
            this.transition.Name = "transition";
            this.transition.ReadOnly = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 253);
            this.Controls.Add(this.transitions_gridview);
            this.Controls.Add(this.transition_Radio);
            this.Controls.Add(this.nodes_Radio);
            this.Controls.Add(this.end_checkbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.nodes_gridview);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nodes_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitions_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nodes_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Node;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox end_checkbox;
        private System.Windows.Forms.RadioButton nodes_Radio;
        private System.Windows.Forms.RadioButton transition_Radio;
        private System.Windows.Forms.DataGridView transitions_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn transition;
    }
}