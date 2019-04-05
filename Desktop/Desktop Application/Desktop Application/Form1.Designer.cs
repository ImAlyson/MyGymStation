namespace Desktop_Application
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close_button = new System.Windows.Forms.PictureBox();
            this.maximize_button = new System.Windows.Forms.PictureBox();
            this.minimize_button = new System.Windows.Forms.PictureBox();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_button.Location = new System.Drawing.Point(1250, 1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(24, 24);
            this.close_button.TabIndex = 0;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            this.close_button.MouseHover += new System.EventHandler(this.close_button_MouseHover);
            // 
            // maximize_button
            // 
            this.maximize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_button.BackColor = System.Drawing.Color.Transparent;
            this.maximize_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize_button.BackgroundImage")));
            this.maximize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximize_button.Location = new System.Drawing.Point(1220, 1);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(24, 24);
            this.maximize_button.TabIndex = 1;
            this.maximize_button.TabStop = false;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click);
            this.maximize_button.MouseLeave += new System.EventHandler(this.maximize_button_MouseLeave);
            this.maximize_button.MouseHover += new System.EventHandler(this.maximize_button_MouseHover);
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimize_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_button.BackgroundImage")));
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize_button.Location = new System.Drawing.Point(1190, 1);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(24, 24);
            this.minimize_button.TabIndex = 2;
            this.minimize_button.TabStop = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            this.minimize_button.MouseLeave += new System.EventHandler(this.minimize_button_MouseLeave);
            this.minimize_button.MouseHover += new System.EventHandler(this.minimize_button_MouseHover);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 695);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 25);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.maximize_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.PictureBox maximize_button;
        private System.Windows.Forms.PictureBox minimize_button;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

