using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebbBrowser
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("file:///C:/Users/comunikime/Bugvoid/Sujeira_Dev/LearningJavaScript/rocketseat/Modulo_3/1.html");
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("input"))
            {
                MessageBox.Show("Consegue");
            }


        }
    }
}
