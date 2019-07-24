using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class MoonText : Form
    {
        
        public MoonText()
        {
            
            InitializeComponent();
        }
        


     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void openrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream s = File.Open(op.FileName, FileMode.Open))
                    {
                        using (StreamReader M = new StreamReader(s))
                        {
                            string leer = M.ReadToEnd();
                            richTextBox1.Text = leer;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender,   EventArgs e)
        {
            

          
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creamos el objeto savefile
            SaveFileDialog sf = new SaveFileDialog();

            //comprobamos que este abierto
            if (sf.ShowDialog() == DialogResult.OK)
            {
                //Usamos Stream
                using (Stream ss = File.Open(sf.FileName, FileMode.CreateNew))

                //Escribimos en el fichero 
                using (StreamWriter swr = new StreamWriter(ss))
                {

                    swr.Write(richTextBox1.Text);

                }




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MoonEditor";
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Add)

            {
                richTextBox1.ZoomFactor += richTextBox1.ZoomFactor = 1;

                if (richTextBox1.ZoomFactor > 9)
                {


               
                    richTextBox1.ZoomFactor = richTextBox1.ZoomFactor = 1;

                }



            }


            if (e.KeyCode == Keys.Subtract)
            {

                richTextBox1.ZoomFactor -= richTextBox1.ZoomFactor = 1;


                if (richTextBox1.ZoomFactor < 1)
                {




               
                    richTextBox1.ZoomFactor += richTextBox1.ZoomFactor = 1;




                }



            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream s = File.Open(op.FileName, FileMode.Open))
                    {
                        using (StreamReader M = new StreamReader(s))
                        {
                            string leer = M.ReadToEnd();
                            richTextBox1.Text = leer;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Creamos el objeto savefile
            SaveFileDialog sf = new SaveFileDialog();
            
            //comprobamos que este abierto
            if (sf.ShowDialog() == DialogResult.OK)
            {
                //Usamos Stream abrimos archivo y sobre escibimos si existe
                using (Stream ss = File.Open(sf.FileName,FileMode.Create))

                //Escribimos en el fichero 
                using (StreamWriter swr = new StreamWriter(ss))
                {
                    swr.Write(richTextBox1.Text);

                    
                }
            }


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 1;
            if (richTextBox1.ZoomFactor > 9)
            {


              
                richTextBox1.ZoomFactor = richTextBox1.ZoomFactor = 1;

            }


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
            try
            {
                richTextBox1.ZoomFactor -= 1;
                if (richTextBox1.ZoomFactor <1)
                {

                      richTextBox1.ZoomFactor += richTextBox1.ZoomFactor = 1;
                  
                }

            }
            catch
            {
                richTextBox1.ZoomFactor = 1;
            }
            
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }



}

    


