namespace LVQforMNIST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelPredict1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTest1 = new System.Windows.Forms.Label();
            this.labelTest2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelPredict2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTest3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelPredict3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDecay1 = new System.Windows.Forms.TextBox();
            this.checkBoxDecay1 = new System.Windows.Forms.CheckBox();
            this.textBoxEpochs1 = new System.Windows.Forms.TextBox();
            this.textBoxCodebookVectors1 = new System.Windows.Forms.TextBox();
            this.textBoxLearningRate1 = new System.Windows.Forms.TextBox();
            this.checkBoxLVQ1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDecay2 = new System.Windows.Forms.TextBox();
            this.checkBoxDecay2 = new System.Windows.Forms.CheckBox();
            this.textBoxWindow2 = new System.Windows.Forms.TextBox();
            this.textBoxEpochs2 = new System.Windows.Forms.TextBox();
            this.textBoxCodebookVectors2 = new System.Windows.Forms.TextBox();
            this.textBoxLearningRate2 = new System.Windows.Forms.TextBox();
            this.checkBoxLVQ2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDecay3 = new System.Windows.Forms.TextBox();
            this.checkBoxDecay3 = new System.Windows.Forms.CheckBox();
            this.textBoxEpsilon3 = new System.Windows.Forms.TextBox();
            this.textBoxWindow3 = new System.Windows.Forms.TextBox();
            this.textBoxEpochs3 = new System.Windows.Forms.TextBox();
            this.textBoxCodebookVectors3 = new System.Windows.Forms.TextBox();
            this.textBoxLearningRate3 = new System.Windows.Forms.TextBox();
            this.checkBoxLVQ3 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(40, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Prediction:";
            // 
            // labelPredict1
            // 
            this.labelPredict1.AutoSize = true;
            this.labelPredict1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPredict1.Location = new System.Drawing.Point(171, 121);
            this.labelPredict1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPredict1.Name = "labelPredict1";
            this.labelPredict1.Size = new System.Drawing.Size(0, 22);
            this.labelPredict1.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 35);
            this.label7.TabIndex = 75;
            this.label7.Text = "LVQ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 78;
            this.label2.Text = "LVQ 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 35);
            this.label6.TabIndex = 81;
            this.label6.Text = "LVQ 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 82;
            this.label3.Text = "Test Acc:";
            // 
            // labelTest1
            // 
            this.labelTest1.AutoSize = true;
            this.labelTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTest1.Location = new System.Drawing.Point(171, 84);
            this.labelTest1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTest1.Name = "labelTest1";
            this.labelTest1.Size = new System.Drawing.Size(0, 22);
            this.labelTest1.TabIndex = 83;
            // 
            // labelTest2
            // 
            this.labelTest2.AutoSize = true;
            this.labelTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTest2.Location = new System.Drawing.Point(171, 101);
            this.labelTest2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTest2.Name = "labelTest2";
            this.labelTest2.Size = new System.Drawing.Size(0, 22);
            this.labelTest2.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(40, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 22);
            this.label12.TabIndex = 88;
            this.label12.Text = "Test Acc:";
            // 
            // labelPredict2
            // 
            this.labelPredict2.AutoSize = true;
            this.labelPredict2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPredict2.Location = new System.Drawing.Point(171, 135);
            this.labelPredict2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPredict2.Name = "labelPredict2";
            this.labelPredict2.Size = new System.Drawing.Size(0, 22);
            this.labelPredict2.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.Location = new System.Drawing.Point(40, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 86;
            this.label14.Text = "Prediction:";
            // 
            // labelTest3
            // 
            this.labelTest3.AutoSize = true;
            this.labelTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTest3.Location = new System.Drawing.Point(171, 106);
            this.labelTest3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTest3.Name = "labelTest3";
            this.labelTest3.Size = new System.Drawing.Size(0, 22);
            this.labelTest3.TabIndex = 93;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(40, 106);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 22);
            this.label16.TabIndex = 92;
            this.label16.Text = "Test Acc:";
            // 
            // labelPredict3
            // 
            this.labelPredict3.AutoSize = true;
            this.labelPredict3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPredict3.Location = new System.Drawing.Point(171, 142);
            this.labelPredict3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPredict3.Name = "labelPredict3";
            this.labelPredict3.Size = new System.Drawing.Size(0, 22);
            this.labelPredict3.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.Location = new System.Drawing.Point(40, 142);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 22);
            this.label18.TabIndex = 90;
            this.label18.Text = "Prediction:";
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(801, 31);
            this.buttonTrain.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(133, 54);
            this.buttonTrain.TabIndex = 95;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.ButtonTrain_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(457, 631);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 38);
            this.buttonClear.TabIndex = 96;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(644, 31);
            this.buttonReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(133, 54);
            this.buttonReadFile.TabIndex = 97;
            this.buttonReadFile.Text = "Read Trained Vectors";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.ButtonReadFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(227, 622);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Learning Rate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 100;
            this.label8.Text = "Codebook Vectors:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "Epochs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 104;
            this.label10.Text = "Epochs:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 103;
            this.label11.Text = "Codebook Vectors:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "Learning Rate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 105;
            this.label15.Text = "Window:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(373, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 109;
            this.label17.Text = "Window:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(375, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 108;
            this.label19.Text = "Epochs:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(306, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 17);
            this.label20.TabIndex = 107;
            this.label20.Text = "Codebook Vectors:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(335, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 17);
            this.label21.TabIndex = 106;
            this.label21.Text = "Learning Rate:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(377, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 17);
            this.label22.TabIndex = 110;
            this.label22.Text = "Epsilon:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDecay1);
            this.groupBox1.Controls.Add(this.checkBoxDecay1);
            this.groupBox1.Controls.Add(this.textBoxEpochs1);
            this.groupBox1.Controls.Add(this.textBoxCodebookVectors1);
            this.groupBox1.Controls.Add(this.textBoxLearningRate1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelPredict1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTest1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(644, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(563, 178);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // textBoxDecay1
            // 
            this.textBoxDecay1.Location = new System.Drawing.Point(467, 123);
            this.textBoxDecay1.Name = "textBoxDecay1";
            this.textBoxDecay1.Size = new System.Drawing.Size(59, 22);
            this.textBoxDecay1.TabIndex = 106;
            this.textBoxDecay1.Text = "0.93";
            this.textBoxDecay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxDecay1
            // 
            this.checkBoxDecay1.AutoSize = true;
            this.checkBoxDecay1.Checked = true;
            this.checkBoxDecay1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecay1.Location = new System.Drawing.Point(359, 123);
            this.checkBoxDecay1.Name = "checkBoxDecay1";
            this.checkBoxDecay1.Size = new System.Drawing.Size(74, 21);
            this.checkBoxDecay1.TabIndex = 105;
            this.checkBoxDecay1.Text = "Decay:";
            this.checkBoxDecay1.UseVisualStyleBackColor = true;
            this.checkBoxDecay1.CheckedChanged += new System.EventHandler(this.CheckBoxDecay1_CheckedChanged);
            // 
            // textBoxEpochs1
            // 
            this.textBoxEpochs1.Location = new System.Drawing.Point(467, 90);
            this.textBoxEpochs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEpochs1.Name = "textBoxEpochs1";
            this.textBoxEpochs1.Size = new System.Drawing.Size(59, 22);
            this.textBoxEpochs1.TabIndex = 104;
            this.textBoxEpochs1.Text = "60";
            this.textBoxEpochs1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCodebookVectors1
            // 
            this.textBoxCodebookVectors1.Location = new System.Drawing.Point(467, 60);
            this.textBoxCodebookVectors1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodebookVectors1.Name = "textBoxCodebookVectors1";
            this.textBoxCodebookVectors1.Size = new System.Drawing.Size(59, 22);
            this.textBoxCodebookVectors1.TabIndex = 103;
            this.textBoxCodebookVectors1.Text = "30";
            this.textBoxCodebookVectors1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLearningRate1
            // 
            this.textBoxLearningRate1.Location = new System.Drawing.Point(467, 30);
            this.textBoxLearningRate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLearningRate1.Name = "textBoxLearningRate1";
            this.textBoxLearningRate1.Size = new System.Drawing.Size(59, 22);
            this.textBoxLearningRate1.TabIndex = 102;
            this.textBoxLearningRate1.Text = "0.1";
            this.textBoxLearningRate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxLVQ1
            // 
            this.checkBoxLVQ1.AutoSize = true;
            this.checkBoxLVQ1.Checked = true;
            this.checkBoxLVQ1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLVQ1.Location = new System.Drawing.Point(650, 105);
            this.checkBoxLVQ1.Name = "checkBoxLVQ1";
            this.checkBoxLVQ1.Size = new System.Drawing.Size(18, 17);
            this.checkBoxLVQ1.TabIndex = 107;
            this.checkBoxLVQ1.UseVisualStyleBackColor = true;
            this.checkBoxLVQ1.CheckedChanged += new System.EventHandler(this.checkBoxLVQ1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDecay2);
            this.groupBox2.Controls.Add(this.checkBoxDecay2);
            this.groupBox2.Controls.Add(this.textBoxWindow2);
            this.groupBox2.Controls.Add(this.textBoxEpochs2);
            this.groupBox2.Controls.Add(this.textBoxCodebookVectors2);
            this.groupBox2.Controls.Add(this.textBoxLearningRate2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelPredict2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelTest2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(644, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(563, 193);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            // 
            // textBoxDecay2
            // 
            this.textBoxDecay2.Location = new System.Drawing.Point(467, 153);
            this.textBoxDecay2.Name = "textBoxDecay2";
            this.textBoxDecay2.Size = new System.Drawing.Size(59, 22);
            this.textBoxDecay2.TabIndex = 111;
            this.textBoxDecay2.Text = "0.99";
            this.textBoxDecay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxDecay2
            // 
            this.checkBoxDecay2.AutoSize = true;
            this.checkBoxDecay2.Checked = true;
            this.checkBoxDecay2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecay2.Location = new System.Drawing.Point(363, 155);
            this.checkBoxDecay2.Name = "checkBoxDecay2";
            this.checkBoxDecay2.Size = new System.Drawing.Size(74, 21);
            this.checkBoxDecay2.TabIndex = 110;
            this.checkBoxDecay2.Text = "Decay:";
            this.checkBoxDecay2.UseVisualStyleBackColor = true;
            this.checkBoxDecay2.CheckedChanged += new System.EventHandler(this.CheckBoxDecay2_CheckedChanged);
            // 
            // textBoxWindow2
            // 
            this.textBoxWindow2.Location = new System.Drawing.Point(467, 121);
            this.textBoxWindow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWindow2.Name = "textBoxWindow2";
            this.textBoxWindow2.Size = new System.Drawing.Size(59, 22);
            this.textBoxWindow2.TabIndex = 109;
            this.textBoxWindow2.Text = "0.3";
            this.textBoxWindow2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEpochs2
            // 
            this.textBoxEpochs2.Location = new System.Drawing.Point(467, 88);
            this.textBoxEpochs2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEpochs2.Name = "textBoxEpochs2";
            this.textBoxEpochs2.Size = new System.Drawing.Size(59, 22);
            this.textBoxEpochs2.TabIndex = 108;
            this.textBoxEpochs2.Text = "15";
            this.textBoxEpochs2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCodebookVectors2
            // 
            this.textBoxCodebookVectors2.Location = new System.Drawing.Point(467, 57);
            this.textBoxCodebookVectors2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodebookVectors2.Name = "textBoxCodebookVectors2";
            this.textBoxCodebookVectors2.Size = new System.Drawing.Size(59, 22);
            this.textBoxCodebookVectors2.TabIndex = 107;
            this.textBoxCodebookVectors2.Text = "30";
            this.textBoxCodebookVectors2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLearningRate2
            // 
            this.textBoxLearningRate2.Location = new System.Drawing.Point(467, 28);
            this.textBoxLearningRate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLearningRate2.Name = "textBoxLearningRate2";
            this.textBoxLearningRate2.Size = new System.Drawing.Size(59, 22);
            this.textBoxLearningRate2.TabIndex = 106;
            this.textBoxLearningRate2.Text = "0.0145";
            this.textBoxLearningRate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxLVQ2
            // 
            this.checkBoxLVQ2.AutoSize = true;
            this.checkBoxLVQ2.Checked = true;
            this.checkBoxLVQ2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLVQ2.Location = new System.Drawing.Point(650, 285);
            this.checkBoxLVQ2.Name = "checkBoxLVQ2";
            this.checkBoxLVQ2.Size = new System.Drawing.Size(18, 17);
            this.checkBoxLVQ2.TabIndex = 114;
            this.checkBoxLVQ2.UseVisualStyleBackColor = true;
            this.checkBoxLVQ2.CheckedChanged += new System.EventHandler(this.checkBoxLVQ2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDecay3);
            this.groupBox3.Controls.Add(this.checkBoxDecay3);
            this.groupBox3.Controls.Add(this.textBoxEpsilon3);
            this.groupBox3.Controls.Add(this.textBoxWindow3);
            this.groupBox3.Controls.Add(this.textBoxEpochs3);
            this.groupBox3.Controls.Add(this.textBoxCodebookVectors3);
            this.groupBox3.Controls.Add(this.textBoxLearningRate3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.labelPredict3);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.labelTest3);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(644, 470);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(563, 228);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            // 
            // textBoxDecay3
            // 
            this.textBoxDecay3.Location = new System.Drawing.Point(467, 185);
            this.textBoxDecay3.Name = "textBoxDecay3";
            this.textBoxDecay3.Size = new System.Drawing.Size(59, 22);
            this.textBoxDecay3.TabIndex = 114;
            this.textBoxDecay3.Text = "0.95";
            this.textBoxDecay3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxDecay3
            // 
            this.checkBoxDecay3.AutoSize = true;
            this.checkBoxDecay3.Checked = true;
            this.checkBoxDecay3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecay3.Location = new System.Drawing.Point(363, 185);
            this.checkBoxDecay3.Name = "checkBoxDecay3";
            this.checkBoxDecay3.Size = new System.Drawing.Size(74, 21);
            this.checkBoxDecay3.TabIndex = 116;
            this.checkBoxDecay3.Text = "Decay:";
            this.checkBoxDecay3.UseVisualStyleBackColor = true;
            this.checkBoxDecay3.CheckedChanged += new System.EventHandler(this.CheckBoxDecay3_CheckedChanged);
            // 
            // textBoxEpsilon3
            // 
            this.textBoxEpsilon3.Location = new System.Drawing.Point(467, 153);
            this.textBoxEpsilon3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEpsilon3.Name = "textBoxEpsilon3";
            this.textBoxEpsilon3.Size = new System.Drawing.Size(59, 22);
            this.textBoxEpsilon3.TabIndex = 115;
            this.textBoxEpsilon3.Text = "0.3";
            this.textBoxEpsilon3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWindow3
            // 
            this.textBoxWindow3.Location = new System.Drawing.Point(467, 122);
            this.textBoxWindow3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWindow3.Name = "textBoxWindow3";
            this.textBoxWindow3.Size = new System.Drawing.Size(59, 22);
            this.textBoxWindow3.TabIndex = 114;
            this.textBoxWindow3.Text = "0.3";
            this.textBoxWindow3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEpochs3
            // 
            this.textBoxEpochs3.Location = new System.Drawing.Point(467, 89);
            this.textBoxEpochs3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEpochs3.Name = "textBoxEpochs3";
            this.textBoxEpochs3.Size = new System.Drawing.Size(59, 22);
            this.textBoxEpochs3.TabIndex = 113;
            this.textBoxEpochs3.Text = "75";
            this.textBoxEpochs3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCodebookVectors3
            // 
            this.textBoxCodebookVectors3.Location = new System.Drawing.Point(467, 58);
            this.textBoxCodebookVectors3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodebookVectors3.Name = "textBoxCodebookVectors3";
            this.textBoxCodebookVectors3.Size = new System.Drawing.Size(59, 22);
            this.textBoxCodebookVectors3.TabIndex = 112;
            this.textBoxCodebookVectors3.Text = "30";
            this.textBoxCodebookVectors3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLearningRate3
            // 
            this.textBoxLearningRate3.Location = new System.Drawing.Point(467, 29);
            this.textBoxLearningRate3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLearningRate3.Name = "textBoxLearningRate3";
            this.textBoxLearningRate3.Size = new System.Drawing.Size(59, 22);
            this.textBoxLearningRate3.TabIndex = 111;
            this.textBoxLearningRate3.Text = "0.05";
            this.textBoxLearningRate3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxLVQ3
            // 
            this.checkBoxLVQ3.AutoSize = true;
            this.checkBoxLVQ3.Checked = true;
            this.checkBoxLVQ3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLVQ3.Location = new System.Drawing.Point(650, 483);
            this.checkBoxLVQ3.Name = "checkBoxLVQ3";
            this.checkBoxLVQ3.Size = new System.Drawing.Size(18, 17);
            this.checkBoxLVQ3.TabIndex = 115;
            this.checkBoxLVQ3.UseVisualStyleBackColor = true;
            this.checkBoxLVQ3.CheckedChanged += new System.EventHandler(this.checkBoxLVQ3_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(953, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 114;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 723);
            this.Controls.Add(this.checkBoxLVQ3);
            this.Controls.Add(this.checkBoxLVQ2);
            this.Controls.Add(this.checkBoxLVQ1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTrain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LVQ for MNIST Classification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPredict1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTest1;
        private System.Windows.Forms.Label labelTest2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPredict2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTest3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelPredict3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEpochs1;
        private System.Windows.Forms.TextBox textBoxCodebookVectors1;
        private System.Windows.Forms.TextBox textBoxLearningRate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxWindow2;
        private System.Windows.Forms.TextBox textBoxEpochs2;
        private System.Windows.Forms.TextBox textBoxCodebookVectors2;
        private System.Windows.Forms.TextBox textBoxLearningRate2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxEpsilon3;
        private System.Windows.Forms.TextBox textBoxWindow3;
        private System.Windows.Forms.TextBox textBoxEpochs3;
        private System.Windows.Forms.TextBox textBoxCodebookVectors3;
        private System.Windows.Forms.TextBox textBoxLearningRate3;
        private System.Windows.Forms.TextBox textBoxDecay1;
        private System.Windows.Forms.CheckBox checkBoxDecay1;
        private System.Windows.Forms.TextBox textBoxDecay2;
        private System.Windows.Forms.CheckBox checkBoxDecay2;
        private System.Windows.Forms.TextBox textBoxDecay3;
        private System.Windows.Forms.CheckBox checkBoxDecay3;
        private System.Windows.Forms.CheckBox checkBoxLVQ1;
        private System.Windows.Forms.CheckBox checkBoxLVQ2;
        private System.Windows.Forms.CheckBox checkBoxLVQ3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

