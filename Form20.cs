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
    public partial class Form20 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form20()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void Form20_Load(object sender, EventArgs e)
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
                    "You have answered"   + score +   "questions correctly." + Environment.NewLine +
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
                    pictureBox1.Image = Properties.Resources._8881;

                    lblQuestion.Text = "ما هي حجم المكعب؟";
                    button1.Text = "215سم";
                    button2.Text = "310سم";
                    button3.Text = "125 سم";
                    button4.Text = "200سم";


                    correctAnswer = 3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._888;

                    lblQuestion.Text = "ما هي حجم الصندوق؟";
                    button1.Text = "150سم";
                    button2.Text = "240سم";
                    button3.Text = "360 سم";
                    button4.Text = "170سم";


                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._111;

                    lblQuestion.Text = "ما هي حجم الكلي للشكل التالي؟";
                    button1.Text = "1687.84سم";
                    button2.Text = "3110سم";
                    button3.Text = "260.87 سم";
                    button4.Text = "1170.6سم";


                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._666;

                    lblQuestion.Text = "ما هي حجم المخروط التالي؟";
                    button1.Text = "200سم";
                    button2.Text = "130.7سم";
                    button3.Text = "167.467 سم";
                    button4.Text = "370سم";


                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._333;

                    lblQuestion.Text = "ما هي حجم المنشور التالي؟";
                    button1.Text = "78.6سم";
                    button2.Text = "66.6سم";
                    button3.Text = "60.8 سم";
                    button4.Text = "70.9سم";


                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._555;

                    lblQuestion.Text = "ما هي حجم الكره؟";
                    button1.Text = "215.8سم";
                    button2.Text = "904.32سم";
                    button3.Text = "500.87 سم";
                    button4.Text = "100سم";


                    correctAnswer = 2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._777;

                    lblQuestion.Text = "ما هي حجم ألاسطوانه اذا علمت ان الارتفاع يساوي  سم16؟";
                    button1.Text = "2125.6سم";
                    button2.Text = "1808.64سم";
                    button3.Text = "1501.5 سم";
                    button4.Text = "3701.8سم";


                    correctAnswer = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._3;

                    lblQuestion.Text = "ما هي حجم الهرم التالي اذا علمت ان الارتفاع يساوي 15سم والقاعده مربع طول ضلعها 8سم؟";
                    button1.Text = "215سم";
                    button2.Text = "646سم";
                    button3.Text = "320 سم";
                    button4.Text = "105سم";


                    correctAnswer = 3;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
