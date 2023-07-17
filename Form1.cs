using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_المساحه_والحجم
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form22 f22 = new Form22();
        Form21 f21 = new Form21();
        Form20 f20 = new Form20();
        Form19 f19 = new Form19();
        Form18 f18 = new Form18();
        Form17 f17 = new Form17();
        Form16 f16 = new Form16();
        Form15 f15 = new Form15();
        Form14 f14 = new Form14();
        Form13 f13 = new Form13();
        Form12 f12 = new Form12();
        Form11 f11 = new Form11();
        Form10 f10 = new Form10();
        Form9 f9 = new Form9();
        Form8 f8 = new Form8();
        Form7 f7 = new Form7();
        Form6 f6 = new Form6();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void spaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void theSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void howToMeasureTheSizeOfObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("اسئلة الهندسه موجهه لطلاب الصف السابع\n عن طريق:احمد حاج يحيى\n التاريخ: 20/5/2020\n");
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.ShowDialog();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        private void phoneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.ShowDialog();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8.ShowDialog();
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9.ShowDialog();
        }

        private void trapezoidalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10.ShowDialog();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f11.ShowDialog();
        }

        private void daltonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f12.ShowDialog();
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f13.ShowDialog();
        }

        private void cubicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14.ShowDialog();
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f15.ShowDialog();
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f16.ShowDialog();
        }

        private void aBallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f17.ShowDialog();
        }

        private void existingPrismToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f18.ShowDialog();
        }

        private void pyramidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f19.ShowDialog();
        }

        private void theSizeQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f20.ShowDialog();
        }

        private void theSpaceQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f21.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void memoryGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memoryGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f22.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the world of space and size");
            SoundPlayer sn = new SoundPlayer("piano.wav");
            sn.Play();
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
