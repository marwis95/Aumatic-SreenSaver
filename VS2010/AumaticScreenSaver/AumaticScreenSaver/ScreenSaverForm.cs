using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AumaticScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            
            this.Bounds = Bounds;
            this.BackColor = Color.Black;
            this.TransparencyKey = BackColor;//tworzy tło przeźroczyste
        }
        private int sWidth = SystemInformation.VirtualScreen.Width;//pobiera szerokosc ekranu
        private int sHeight = SystemInformation.VirtualScreen.Height;//pobiera wysokosc ekranu
        private Random los = new Random();//liczba losowa
        private bool bol;//pomocnicza zmienna do okreslenia kierunku linii
        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();//ukrywa kursor
            TopMost = true;
            panel1.Width = sWidth;//ustawia szerokosc linii na cala szerokosc ekranu
            panel1.Height = 1;//ustawia wysokosc linii na 1px
            panel1.BackColor = Color.White;//kolor linii biały
            if (los.NextDouble() >= 0.5)//losuje liczbe i sprawdza czy jest wkiesza od 0.5. Jesli tak to linia zaczyna od góry ekranu
            {
                bol = true;
                panel1.Top = 0;
            }
            else {//Jeśli nie linia zaczyna od dołu ekranu
                bol = false;
                panel1.Top = sHeight;
            }
            
            Timer myTimer = new Timer();//tworzy nowy timer

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\AumaticScreenSaver");
            if (key == null)
                myTimer.Interval = 1500;
            else
                myTimer.Interval = Convert.ToInt32(key.GetValue("Interval"));
            myTimer.Tick += new EventHandler(timer1_Tick);//dodaje event
           
            myTimer.Start();//start timer
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bol)//jesli true to panel przesuwa sie do dołu
            {
                if (panel1.Top == sHeight)
                {
                    panel1.Top = 0;
                }
                panel1.Top += 1;
            }
            else {//jesli false do do góry
                if (panel1.Top == 0)
                {
                    panel1.Top = sHeight;
                }
                panel1.Top -= 1;
            }
        }
    }
}
