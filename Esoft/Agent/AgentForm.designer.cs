namespace Esoft
{
    partial class AgentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Create_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Agents_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.Agents_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Delete_btn.BorderRadius = 5;
            this.Delete_btn.BorderThickness = 2;
            this.Delete_btn.CheckedState.Parent = this.Delete_btn;
            this.Delete_btn.CustomImages.Parent = this.Delete_btn;
            this.Delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_btn.DisabledState.Parent = this.Delete_btn;
            this.Delete_btn.FillColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Delete_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Delete_btn.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.HoverState.Parent = this.Delete_btn;
            this.Delete_btn.Location = new System.Drawing.Point(690, 403);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(100, 35);
            this.Delete_btn.TabIndex = 15;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.BorderRadius = 5;
            this.Create_btn.CheckedState.Parent = this.Create_btn;
            this.Create_btn.CustomImages.Parent = this.Create_btn;
            this.Create_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Create_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Create_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Create_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Create_btn.DisabledState.Parent = this.Create_btn;
            this.Create_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_btn.ForeColor = System.Drawing.Color.White;
            this.Create_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Create_btn.HoverState.Parent = this.Create_btn;
            this.Create_btn.Location = new System.Drawing.Point(14, 403);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.ShadowDecoration.Parent = this.Create_btn;
            this.Create_btn.Size = new System.Drawing.Size(100, 35);
            this.Create_btn.TabIndex = 16;
            this.Create_btn.Text = "Создать";
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(341, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(159, 22);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Список риэлторов";
            // 
            // Agents_table
            // 
            this.Agents_table.AllowUserToAddRows = false;
            this.Agents_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Agents_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Agents_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Agents_table.BackgroundColor = System.Drawing.Color.White;
            this.Agents_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Agents_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Agents_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Agents_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Agents_table.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Agents_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Agents_table.EnableHeadersVisualStyles = false;
            this.Agents_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.Agents_table.Location = new System.Drawing.Point(14, 47);
            this.Agents_table.MultiSelect = false;
            this.Agents_table.Name = "Agents_table";
            this.Agents_table.ReadOnly = true;
            this.Agents_table.RowHeadersVisible = false;
            this.Agents_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Agents_table.Size = new System.Drawing.Size(776, 348);
            this.Agents_table.TabIndex = 13;
            this.Agents_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Agents_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Agents_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Agents_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Agents_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Agents_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Agents_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.Agents_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Agents_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Agents_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Agents_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Agents_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Agents_table.ThemeStyle.HeaderStyle.Height = 24;
            this.Agents_table.ThemeStyle.ReadOnly = true;
            this.Agents_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Agents_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Agents_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Agents_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Agents_table.ThemeStyle.RowsStyle.Height = 22;
            this.Agents_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Agents_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Agents_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agents_table_CellClick);
            this.Agents_table.DoubleClick += new System.EventHandler(this.Agents_table_DoubleClick);
            // 
            // Back_btn
            // 
            this.Back_btn.CheckedState.Parent = this.Back_btn;
            this.Back_btn.CustomImages.Parent = this.Back_btn;
            this.Back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_btn.DisabledState.Parent = this.Back_btn;
            this.Back_btn.FillColor = System.Drawing.Color.White;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.HoverState.Parent = this.Back_btn;
            this.Back_btn.Image = global::Esoft.Properties.Resources.arrow_left;
            this.Back_btn.Location = new System.Drawing.Point(726, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.ShadowDecoration.Parent = this.Back_btn;
            this.Back_btn.Size = new System.Drawing.Size(29, 29);
            this.Back_btn.TabIndex = 12;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click_1);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Esoft.Properties.Resources.logo2;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(11, 12);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(93, 29);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(761, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Agents_table);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentForm";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Agents_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Create_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView Agents_table;
        private Guna.UI2.WinForms.Guna2Button Back_btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}