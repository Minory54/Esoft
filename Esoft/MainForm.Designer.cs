namespace Esoft
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Client_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Agent_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Property_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Supplies_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Demands_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
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
            // Client_btn
            // 
            this.Client_btn.BorderRadius = 5;
            this.Client_btn.CheckedState.Parent = this.Client_btn;
            this.Client_btn.CustomImages.Parent = this.Client_btn;
            this.Client_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Client_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Client_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Client_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Client_btn.DisabledState.Parent = this.Client_btn;
            this.Client_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Client_btn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.Client_btn.ForeColor = System.Drawing.Color.White;
            this.Client_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Client_btn.HoverState.Parent = this.Client_btn;
            this.Client_btn.Location = new System.Drawing.Point(119, 151);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.ShadowDecoration.Parent = this.Client_btn;
            this.Client_btn.Size = new System.Drawing.Size(160, 37);
            this.Client_btn.TabIndex = 2;
            this.Client_btn.Text = "Клиенты";
            this.Client_btn.Click += new System.EventHandler(this.Client_btn_Click);
            // 
            // Agent_btn
            // 
            this.Agent_btn.BorderRadius = 5;
            this.Agent_btn.CheckedState.Parent = this.Agent_btn;
            this.Agent_btn.CustomImages.Parent = this.Agent_btn;
            this.Agent_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Agent_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Agent_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Agent_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Agent_btn.DisabledState.Parent = this.Agent_btn;
            this.Agent_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Agent_btn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.Agent_btn.ForeColor = System.Drawing.Color.White;
            this.Agent_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Agent_btn.HoverState.Parent = this.Agent_btn;
            this.Agent_btn.Location = new System.Drawing.Point(308, 151);
            this.Agent_btn.Name = "Agent_btn";
            this.Agent_btn.ShadowDecoration.Parent = this.Agent_btn;
            this.Agent_btn.Size = new System.Drawing.Size(160, 37);
            this.Agent_btn.TabIndex = 2;
            this.Agent_btn.Text = "Риэлторы";
            this.Agent_btn.Click += new System.EventHandler(this.Agent_btn_Click);
            // 
            // Property_btn
            // 
            this.Property_btn.BorderRadius = 5;
            this.Property_btn.CheckedState.Parent = this.Property_btn;
            this.Property_btn.CustomImages.Parent = this.Property_btn;
            this.Property_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Property_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Property_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Property_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Property_btn.DisabledState.Parent = this.Property_btn;
            this.Property_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Property_btn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.Property_btn.ForeColor = System.Drawing.Color.White;
            this.Property_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Property_btn.HoverState.Parent = this.Property_btn;
            this.Property_btn.Location = new System.Drawing.Point(118, 204);
            this.Property_btn.Name = "Property_btn";
            this.Property_btn.ShadowDecoration.Parent = this.Property_btn;
            this.Property_btn.Size = new System.Drawing.Size(350, 40);
            this.Property_btn.TabIndex = 2;
            this.Property_btn.Text = "Недвижимость";
            this.Property_btn.Click += new System.EventHandler(this.Property_btn_Click);
            // 
            // Supplies_btn
            // 
            this.Supplies_btn.BorderRadius = 5;
            this.Supplies_btn.CheckedState.Parent = this.Supplies_btn;
            this.Supplies_btn.CustomImages.Parent = this.Supplies_btn;
            this.Supplies_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Supplies_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Supplies_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Supplies_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Supplies_btn.DisabledState.Parent = this.Supplies_btn;
            this.Supplies_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Supplies_btn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.Supplies_btn.ForeColor = System.Drawing.Color.White;
            this.Supplies_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Supplies_btn.HoverState.Parent = this.Supplies_btn;
            this.Supplies_btn.Location = new System.Drawing.Point(118, 260);
            this.Supplies_btn.Name = "Supplies_btn";
            this.Supplies_btn.ShadowDecoration.Parent = this.Supplies_btn;
            this.Supplies_btn.Size = new System.Drawing.Size(350, 40);
            this.Supplies_btn.TabIndex = 2;
            this.Supplies_btn.Text = "Предложения";
            this.Supplies_btn.Click += new System.EventHandler(this.Supplies_btn_Click);
            // 
            // Demands_btn
            // 
            this.Demands_btn.BorderRadius = 5;
            this.Demands_btn.CheckedState.Parent = this.Demands_btn;
            this.Demands_btn.CustomImages.Parent = this.Demands_btn;
            this.Demands_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Demands_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Demands_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Demands_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Demands_btn.DisabledState.Parent = this.Demands_btn;
            this.Demands_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.Demands_btn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.Demands_btn.ForeColor = System.Drawing.Color.White;
            this.Demands_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.Demands_btn.HoverState.Parent = this.Demands_btn;
            this.Demands_btn.Location = new System.Drawing.Point(118, 316);
            this.Demands_btn.Name = "Demands_btn";
            this.Demands_btn.ShadowDecoration.Parent = this.Demands_btn;
            this.Demands_btn.Size = new System.Drawing.Size(350, 40);
            this.Demands_btn.TabIndex = 2;
            this.Demands_btn.Text = "Запросы";
            this.Demands_btn.Click += new System.EventHandler(this.Demands_btn_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(560, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Esoft.Properties.Resources.logo2;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(8, 24);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(584, 68);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Demands_btn);
            this.Controls.Add(this.Supplies_btn);
            this.Controls.Add(this.Property_btn);
            this.Controls.Add(this.Agent_btn);
            this.Controls.Add(this.Client_btn);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button Property_btn;
        private Guna.UI2.WinForms.Guna2Button Agent_btn;
        private Guna.UI2.WinForms.Guna2Button Client_btn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button Demands_btn;
        private Guna.UI2.WinForms.Guna2Button Supplies_btn;
    }
}

