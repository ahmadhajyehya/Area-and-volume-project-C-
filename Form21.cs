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
    public partial class Form21 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form21()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }



        private void Form21_Load(object sender, EventArgs e)
        {


        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Inded!" + Environment.NewLine +
                    "You have answered" + score + "questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "click Ok to test yourself again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            questionNumber++;
            askQuestion(questionNumber);

        }
        private void askQuestion(int qunm)
        {
            switch (qunm)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._3333;

                    lblQuestion.Text = "ما هي مساحة المربع الداخلي؟";
                    button1.Text = "30سم";
                    button2.Text = "48سم";
                    button3.Text = "64 سم";
                    button4.Text = "70سم";


                    correctAnswer = 3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2222;

                    lblQuestion.Text = "ما هي مساحة المثلث داخل الشكل التالي؟";
                    button1.Text = "10سم";
                    button2.Text = "34سم";
                    button3.Text = "25 سم";
                    button4.Text = "20 سم";


                    correctAnswer = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4444;

                    lblQuestion.Text = "ما هي مساحة الدائره؟";
                    button1.Text = "42.49سم";
                    button2.Text = "30.1سم";
                    button3.Text = "60.78 سم";
                    button4.Text = "70.61سم";


                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._999;

                    lblQuestion.Text = "ما هي المساحه الكليه للشكل التالي؟";
                    button1.Text = "251.5سم";
                    button2.Text = "790.6سم";
                    button3.Text = "50.06 سم";
                    button4.Text = "70.98سم";


                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._222;

                    lblQuestion.Text = "ما هي مساحة الكليه للشكل التالي؟";
                    button1.Text = "193 سم";
                    button2.Text = "166سم";
                    button3.Text = "620 سم";
                    button4.Text = "970سم";


                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._1010;

                    lblQuestion.Text = "ما هي مساحة الدالتون اذا علمت ان ED=CB ؟";
                    button1.Text = "14سم";
                    button2.Text = "26سم";
                    button3.Text = "21.6سم";
                    button4.Text = "9.1سم";


                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._5555;

                    lblQuestion.Text = "ما هي مساحة المثلث التالي؟";
                    button1.Text = "11.5سم";
                    button2.Text = "27.8سم";
                    button3.Text = "30 سم";
                    button4.Text = "10سم";


                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._2222;

                    lblQuestion.Text = "ما هي المساحه الكليه للشكل التالي؟";
                    button1.Text = "100سم";
                    button2.Text = "175سم";
                    button3.Text = "120 سم";
                    button4.Text = "255سم";


                    correctAnswer = 2;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
