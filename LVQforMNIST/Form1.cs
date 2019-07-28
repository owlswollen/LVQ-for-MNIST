using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LVQforMNIST
{
    public partial class Form1 : Form
    {
        //VISUALS//
        #region
        public static int trainDataCount;
        static ProgressBar myProgress;
        bool calc = false;
        bool draw = false, erase = false;
        float[] matrix = new float[mnistSize];
        MyButton[,] buttons = new MyButton[28, 28];
        public Form1()
        {
            InitializeComponent();
            myProgress = progressBar1;
            myProgress.Minimum = 0;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            InitButtons();
            try
            {
                Data.ReadData(trainData, testData, mnistSize);
            }
            catch
            {
                MessageBox.Show("File not found.");
                return;
            }
            Console.WriteLine("Data read");
        }
        public static void Loading(int iteration)
        {
            if (iteration <= myProgress.Maximum && iteration >= 0)
                myProgress.Value = iteration;
        }
        void InitButtons()
        {
            int buttonSize = 15;
            int paddingY = 80;
            int paddingX = 25;
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    matrix[j + i * 28] = 0;
                    buttons[i, j] = new MyButton();
                    buttons[i, j].Enabled = false;
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderColor = Color.Black;
                    buttons[i, j].i = i;
                    buttons[i, j].j = j;
                    buttons[i, j].Height = buttons[i, j].Width = buttonSize;
                    buttons[i, j].Location = new Point(paddingX + i * buttonSize, paddingY + j * buttonSize);
                    buttons[i, j].BackColor = Color.White;
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].MouseMove += Form1_MouseMove;
                }
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (erase)
            {
                Control myControl = GetChildAtPoint(e.Location);
                if (myControl is MyButton)
                {
                    MyButton b = (MyButton)myControl;
                    matrix[b.i + b.j * 28] = 0;
                    buttons[b.i, b.j].BackColor = Color.White;
                }
            }
            if (draw)
            {
                Control myControl = GetChildAtPoint(e.Location);
                if (myControl is MyButton)
                {
                    MyButton b = (MyButton)myControl;
                    matrix[b.i + b.j * 28] = 1;
                    buttons[b.i, b.j].BackColor = Color.Black;
                    if (b.i > 0 && matrix[(b.i - 1) + b.j * 28] == 0)
                    {
                        matrix[(b.i - 1) + b.j * 28] = 0.5f;
                        buttons[(b.i - 1), b.j].BackColor = Color.Gray;
                    }
                    if (b.i < 27 && matrix[(b.i + 1) + b.j * 28] == 0)
                    {
                        matrix[(b.i + 1) + b.j * 28] = 0.5f;
                        buttons[(b.i + 1), b.j].BackColor = Color.Gray;
                    }
                    if (b.j > 0 && matrix[b.i + (b.j - 1) * 28] == 0)
                    {
                        matrix[b.i + (b.j - 1) * 28] = 0.5f;
                        buttons[b.i, b.j - 1].BackColor = Color.Gray;
                    }
                    if (b.j < 27 && matrix[b.i + (b.j + 1) * 28] == 0)
                    {
                        matrix[b.i + (b.j + 1) * 28] = 0.5f;
                        buttons[b.i, (b.j + 1)].BackColor = Color.Gray;
                    }
                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                erase = false;
            }
            if (me.Button == MouseButtons.Left)
            {
                draw = false;
            }

            Calculate();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                erase = true;
            }
            if (me.Button == MouseButtons.Left)
            {
                draw = true;
            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    matrix[i + j * 28] = 0;
                    buttons[i, j].BackColor = Color.White;
                }
            }
        }
        private void Calculate()
        {
            if (calc)
            {
                if (checkBoxLVQ1.Checked)
                    labelPredict1.Text = (myLVQ1.Check(matrix)).ToString();
                if (checkBoxLVQ2.Checked)
                    labelPredict2.Text = (myLVQ2.Check(matrix)).ToString();
                if (checkBoxLVQ3.Checked)
                    labelPredict3.Text = (myLVQ3.Check(matrix)).ToString();
            }
        }
        private void CheckBoxDecay1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDecay1.Enabled = checkBoxDecay1.Checked;
        }
        private void CheckBoxDecay2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDecay2.Enabled = checkBoxDecay2.Checked;
        }
        private void CheckBoxDecay3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDecay3.Enabled = checkBoxDecay3.Checked;
        }
        private void checkBoxLVQ1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBoxLVQ1.Checked;
        }
        private void checkBoxLVQ2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = checkBoxLVQ2.Checked;
        }
        private void checkBoxLVQ3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = checkBoxLVQ3.Checked;
        }
        #endregion

        //CONSTRUCTION//
        #region
        protected List<float[]>[] trainData = new List<float[]>[10];
        protected List<float[]>[] testData = new List<float[]>[10];

        static int mnistSize = 28 * 28;
        LVQ1 myLVQ1;
        LVQ2 myLVQ2;
        LVQ3 myLVQ3;

        float learningRate1;
        int codebookVectorCount1;
        int iterationCount1;
        float decay1;

        float learningRate2;
        int codebookVectorCount2;
        int iterationCount2;
        float window2;
        float decay2;

        float learningRate3;
        int codebookVectorCount3;
        int iterationCount3;
        float window3;
        float epsilon3;
        float decay3;

        // run algorithms & write trained codebook vectors to files
        private void ButtonTrain_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLVQ1.Checked)
                {
                    learningRate1 = Single.Parse(textBoxLearningRate1.Text, CultureInfo.InvariantCulture);
                    codebookVectorCount1 = Convert.ToInt16(textBoxCodebookVectors1.Text);
                    iterationCount1 = Convert.ToInt16(textBoxEpochs1.Text);
                    decay1 = textBoxDecay1.Enabled ? Single.Parse(textBoxDecay1.Text, CultureInfo.InvariantCulture) : 1;
                }
                if (checkBoxLVQ2.Checked)
                {
                    learningRate2 = Single.Parse(textBoxLearningRate2.Text, CultureInfo.InvariantCulture);
                    codebookVectorCount2 = Convert.ToInt16(textBoxCodebookVectors2.Text);
                    iterationCount2 = Convert.ToInt16(textBoxEpochs2.Text);
                    window2 = Single.Parse(textBoxWindow2.Text, CultureInfo.InvariantCulture);
                    decay2 = textBoxDecay2.Enabled ? Single.Parse(textBoxDecay2.Text, CultureInfo.InvariantCulture) : 1;
                }
                if (checkBoxLVQ3.Checked)
                {
                    learningRate3 = Single.Parse(textBoxLearningRate3.Text, CultureInfo.InvariantCulture);
                    codebookVectorCount3 = Convert.ToInt16(textBoxCodebookVectors3.Text);
                    iterationCount3 = Convert.ToInt16(textBoxEpochs3.Text);
                    window3 = Single.Parse(textBoxWindow3.Text, CultureInfo.InvariantCulture);
                    epsilon3 = Single.Parse(textBoxEpsilon3.Text, CultureInfo.InvariantCulture);
                    decay3 = textBoxDecay3.Enabled ? Single.Parse(textBoxDecay3.Text, CultureInfo.InvariantCulture) : 1;
                }
            }
            catch
            {
                MessageBox.Show("Invalid parameter(s).");
                return;
            }

            progressBar1.Maximum = 0;
            progressBar1.Maximum += checkBoxLVQ1.Checked ? iterationCount1 : 0;
            progressBar1.Maximum += checkBoxLVQ2.Checked ? iterationCount2 : 0;
            progressBar1.Maximum += checkBoxLVQ3.Checked ? iterationCount3 : 0;
            progressBar1.Value = 0;
            LVQ.iteration = 0;

            if (checkBoxLVQ1.Checked)
            {
                myLVQ1 = new LVQ1(trainData, testData, learningRate1, codebookVectorCount1, iterationCount1, "LVQ1", decay1);
                myLVQ1.Epoch();
                labelTest1.Text = (myLVQ1.averageAccuracy).ToString();
            }
            if (checkBoxLVQ2.Checked)
            {
                myLVQ2 = new LVQ2(trainData, testData, learningRate2, codebookVectorCount2, iterationCount2, "LVQ2", window2, decay2);
                myLVQ2.Epoch();
                labelTest2.Text = (myLVQ2.averageAccuracy).ToString();
            }
            if (checkBoxLVQ3.Checked)
            {
                myLVQ3 = new LVQ3(trainData, testData, learningRate3, codebookVectorCount3, iterationCount3, "LVQ3", window3, epsilon3, decay3);
                myLVQ3.Epoch();
                labelTest3.Text = (myLVQ3.averageAccuracy).ToString();
            }

            try
            {
                if (checkBoxLVQ1.Checked)
                    Data.WriteToBinaryFile("LVQ1", myLVQ1, false);
                if (checkBoxLVQ2.Checked)
                    Data.WriteToBinaryFile("LVQ2", myLVQ2, false);
                if (checkBoxLVQ3.Checked)
                    Data.WriteToBinaryFile("LVQ3", myLVQ3, false);
            }
            catch
            {
                MessageBox.Show("Path not found.");
            }

            calc = true;
        }
        // read trained codebook vectors from files
        private void ButtonReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLVQ1.Checked)
                {
                    myLVQ1 = Data.ReadFromBinaryFile<LVQ1>("LVQ1" + ".bin");
                }
                if (checkBoxLVQ2.Checked)
                {
                    myLVQ2 = Data.ReadFromBinaryFile<LVQ2>("LVQ2" + ".bin");
                }
                if (checkBoxLVQ3.Checked)
                {
                    myLVQ3 = Data.ReadFromBinaryFile<LVQ3>("LVQ3" + ".bin");
                }
            }
            catch
            {
                MessageBox.Show("File not found.");
                return;
            }
            if (checkBoxLVQ1.Checked)
            {
                labelTest1.Text = (myLVQ1.averageAccuracy).ToString();
            }
            if (checkBoxLVQ2.Checked)
            {
                labelTest2.Text = (myLVQ2.averageAccuracy).ToString();
            }
            if (checkBoxLVQ3.Checked)
            {
                labelTest3.Text = (myLVQ3.averageAccuracy).ToString();
            }
            calc = true;
        }
        #endregion
    }
    public class MyButton : Button
    {
        public int i, j;
    }
}
