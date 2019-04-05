using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Desktop_Application
{
    public partial class Form1 : Form
    {
        // Round form dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // Imagens Fechar
        Image closeImage = new Bitmap(@"E:\Backup\Dev\Icons\png\close_button1_light.png");
        Image closeHoverImage = new Bitmap(@"E:\Backup\Dev\Icons\png\close_button1.png");

        // Imagens Maximizar
        Image resizeImage = new Bitmap(@"E:\Backup\Dev\Icons\png\restore_maximize_button1_light.png");
        Image resizeHoverImage = new Bitmap(@"E:\Backup\Dev\Icons\png\restore_maximize_button1.png");
        Image maximizeImage = new Bitmap(@"E:\Backup\Dev\Icons\png\maximize_button1_light.png");
        Image maximizeHoverImage = new Bitmap(@"E:\Backup\Dev\Icons\png\maximize_button1.png");

        // Imagens Minimizar
        Image minimizeImage = new Bitmap(@"E:\Backup\Dev\Icons\png\minimize_button1_light.png");
        Image minimizeHoverImage = new Bitmap(@"E:\Backup\Dev\Icons\png\minimize_button1.png");

        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));
        }

        // Botão de Minimizar
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_button_MouseHover(object sender, EventArgs e)
        {
            minimize_button.BackgroundImage = minimizeHoverImage;
        }

        private void minimize_button_MouseLeave(object sender, EventArgs e)
        {
            minimize_button.BackgroundImage = minimizeImage;
        }

        // Botão de Maximizar
        private void maximize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximize_button.BackgroundImage = resizeImage;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximize_button.BackgroundImage = maximizeImage;
            }
        }

        private void maximize_button_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                maximize_button.BackgroundImage = maximizeHoverImage;
            else
                maximize_button.BackgroundImage = resizeHoverImage;
        }

        private void maximize_button_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                maximize_button.BackgroundImage = maximizeImage;
            else
                maximize_button.BackgroundImage = resizeImage;
        }
        
        // Botão de fechar
        private void close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair do programa?", "Atenção!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void close_button_MouseHover(object sender, EventArgs e)
        {
            close_button.BackgroundImage = closeHoverImage;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.BackgroundImage = closeImage;
        }
    }
}
