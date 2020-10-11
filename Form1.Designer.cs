namespace StudentInfo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드
        private void InitializeComponent()
        {
            this.buttonLoadInfo = new System.Windows.Forms.Button();
            this.groupBoxStudent1 = new System.Windows.Forms.GroupBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.comboBoxGender1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGender2 = new System.Windows.Forms.ComboBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGender3 = new System.Windows.Forms.ComboBox();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxName3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoLoading = new System.Windows.Forms.CheckBox();
            this.labelCorrentStdNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMemo1 = new System.Windows.Forms.TextBox();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonDelete3 = new System.Windows.Forms.Button();
            this.textBoxMemo2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMemo3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxStudent1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadInfo
            // 
            this.buttonLoadInfo.Location = new System.Drawing.Point(22, 26);
            this.buttonLoadInfo.Name = "buttonLoadInfo";
            this.buttonLoadInfo.Size = new System.Drawing.Size(178, 78);
            this.buttonLoadInfo.TabIndex = 0;
            this.buttonLoadInfo.Text = "학생정보 불러오기";
            this.buttonLoadInfo.UseVisualStyleBackColor = true;
            this.buttonLoadInfo.Click += new System.EventHandler(this.ButtonLoadInfo_Click);
            // 
            // groupBoxStudent1
            // 
            this.groupBoxStudent1.Controls.Add(this.buttonDelete1);
            this.groupBoxStudent1.Controls.Add(this.button2);
            this.groupBoxStudent1.Controls.Add(this.button3);
            this.groupBoxStudent1.Controls.Add(this.textBoxMemo1);
            this.groupBoxStudent1.Controls.Add(this.label10);
            this.groupBoxStudent1.Controls.Add(this.buttonSave1);
            this.groupBoxStudent1.Controls.Add(this.label3);
            this.groupBoxStudent1.Controls.Add(this.label2);
            this.groupBoxStudent1.Controls.Add(this.label1);
            this.groupBoxStudent1.Controls.Add(this.comboBoxGender1);
            this.groupBoxStudent1.Controls.Add(this.textBoxNumber1);
            this.groupBoxStudent1.Controls.Add(this.textBoxName1);
            this.groupBoxStudent1.Location = new System.Drawing.Point(22, 129);
            this.groupBoxStudent1.Name = "groupBoxStudent1";
            this.groupBoxStudent1.Size = new System.Drawing.Size(178, 279);
            this.groupBoxStudent1.TabIndex = 1;
            this.groupBoxStudent1.TabStop = false;
            this.groupBoxStudent1.Text = "학생1";
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(55, 29);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 21);
            this.textBoxName1.TabIndex = 0;
            this.textBoxName1.Text = "학생정보 없음";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(55, 55);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(100, 21);
            this.textBoxNumber1.TabIndex = 1;
            // 
            // comboBoxGender1
            // 
            this.comboBoxGender1.FormattingEnabled = true;
            this.comboBoxGender1.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxGender1.Location = new System.Drawing.Point(55, 81);
            this.comboBoxGender1.Name = "comboBoxGender1";
            this.comboBoxGender1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxGender1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "학번";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "성별";
            // 
            // buttonSave1
            // 
            this.buttonSave1.Location = new System.Drawing.Point(55, 214);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(100, 21);
            this.buttonSave1.TabIndex = 6;
            this.buttonSave1.Text = "저장";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.ButtonSave1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMemo2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonDelete2);
            this.groupBox1.Controls.Add(this.buttonSave2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxGender2);
            this.groupBox1.Controls.Add(this.textBoxNumber2);
            this.groupBox1.Controls.Add(this.textBoxName2);
            this.groupBox1.Location = new System.Drawing.Point(230, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생2";
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(55, 214);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(100, 21);
            this.buttonSave2.TabIndex = 6;
            this.buttonSave2.Text = "저장";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.ButtonSave2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "학번";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "이름";
            // 
            // comboBoxGender2
            // 
            this.comboBoxGender2.FormattingEnabled = true;
            this.comboBoxGender2.Location = new System.Drawing.Point(55, 81);
            this.comboBoxGender2.Name = "comboBoxGender2";
            this.comboBoxGender2.Size = new System.Drawing.Size(100, 20);
            this.comboBoxGender2.TabIndex = 2;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(55, 55);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 21);
            this.textBoxNumber2.TabIndex = 1;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(55, 29);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 21);
            this.textBoxName2.TabIndex = 0;
            this.textBoxName2.Text = "학생정보 없음";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMemo3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonDelete3);
            this.groupBox2.Controls.Add(this.buttonSave3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxGender3);
            this.groupBox2.Controls.Add(this.textBoxNumber3);
            this.groupBox2.Controls.Add(this.textBoxName3);
            this.groupBox2.Location = new System.Drawing.Point(436, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 279);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생3";
            // 
            // buttonSave3
            // 
            this.buttonSave3.Location = new System.Drawing.Point(55, 214);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(100, 21);
            this.buttonSave3.TabIndex = 6;
            this.buttonSave3.Text = "저장";
            this.buttonSave3.UseVisualStyleBackColor = true;
            this.buttonSave3.Click += new System.EventHandler(this.ButtonSave3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "성별";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "학번";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "이름";
            // 
            // comboBoxGender3
            // 
            this.comboBoxGender3.FormattingEnabled = true;
            this.comboBoxGender3.Location = new System.Drawing.Point(55, 81);
            this.comboBoxGender3.Name = "comboBoxGender3";
            this.comboBoxGender3.Size = new System.Drawing.Size(100, 20);
            this.comboBoxGender3.TabIndex = 2;
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.Location = new System.Drawing.Point(55, 55);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(100, 21);
            this.textBoxNumber3.TabIndex = 1;
            // 
            // textBoxName3
            // 
            this.textBoxName3.Location = new System.Drawing.Point(55, 29);
            this.textBoxName3.Name = "textBoxName3";
            this.textBoxName3.Size = new System.Drawing.Size(100, 21);
            this.textBoxName3.TabIndex = 0;
            this.textBoxName3.Text = "학생정보 없음";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCorrentStdNum);
            this.groupBox3.Controls.Add(this.checkBoxAutoLoading);
            this.groupBox3.Location = new System.Drawing.Point(230, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 78);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "설정 및 정보";
            // 
            // checkBoxAutoLoading
            // 
            this.checkBoxAutoLoading.AutoSize = true;
            this.checkBoxAutoLoading.Location = new System.Drawing.Point(22, 21);
            this.checkBoxAutoLoading.Name = "checkBoxAutoLoading";
            this.checkBoxAutoLoading.Size = new System.Drawing.Size(244, 16);
            this.checkBoxAutoLoading.TabIndex = 0;
            this.checkBoxAutoLoading.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxAutoLoading.UseVisualStyleBackColor = true;
            this.checkBoxAutoLoading.CheckedChanged += new System.EventHandler(this.CheckBoxAutoLoading_CheckedChanged);
            // 
            // labelCorrentStdNum
            // 
            this.labelCorrentStdNum.AutoSize = true;
            this.labelCorrentStdNum.Location = new System.Drawing.Point(20, 50);
            this.labelCorrentStdNum.Name = "labelCorrentStdNum";
            this.labelCorrentStdNum.Size = new System.Drawing.Size(131, 12);
            this.labelCorrentStdNum.TabIndex = 1;
            this.labelCorrentStdNum.Text = "현재 저장된 학생 수 : 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "메모";
            // 
            // textBoxMemo1
            // 
            this.textBoxMemo1.Location = new System.Drawing.Point(55, 105);
            this.textBoxMemo1.Multiline = true;
            this.textBoxMemo1.Name = "textBoxMemo1";
            this.textBoxMemo1.Size = new System.Drawing.Size(100, 99);
            this.textBoxMemo1.TabIndex = 8;
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(55, 241);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(100, 21);
            this.buttonDelete1.TabIndex = 9;
            this.buttonDelete1.Text = "삭제";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.ButtonDelete1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Location = new System.Drawing.Point(55, 241);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(100, 21);
            this.buttonDelete2.TabIndex = 12;
            this.buttonDelete2.Text = "삭제";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.ButtonDelete2_Click);
            // 
            // buttonDelete3
            // 
            this.buttonDelete3.Location = new System.Drawing.Point(55, 241);
            this.buttonDelete3.Name = "buttonDelete3";
            this.buttonDelete3.Size = new System.Drawing.Size(100, 21);
            this.buttonDelete3.TabIndex = 13;
            this.buttonDelete3.Text = "삭제";
            this.buttonDelete3.UseVisualStyleBackColor = true;
            this.buttonDelete3.Click += new System.EventHandler(this.ButtonDelete3_Click);
            // 
            // textBoxMemo2
            // 
            this.textBoxMemo2.Location = new System.Drawing.Point(55, 106);
            this.textBoxMemo2.Multiline = true;
            this.textBoxMemo2.Name = "textBoxMemo2";
            this.textBoxMemo2.Size = new System.Drawing.Size(100, 99);
            this.textBoxMemo2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "메모";
            // 
            // textBoxMemo3
            // 
            this.textBoxMemo3.Location = new System.Drawing.Point(55, 107);
            this.textBoxMemo3.Multiline = true;
            this.textBoxMemo3.Name = "textBoxMemo3";
            this.textBoxMemo3.Size = new System.Drawing.Size(100, 99);
            this.textBoxMemo3.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "메모";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStudent1);
            this.Controls.Add(this.buttonLoadInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxStudent1.ResumeLayout(false);
            this.groupBoxStudent1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadInfo;
        private System.Windows.Forms.GroupBox groupBoxStudent1;
        private System.Windows.Forms.ComboBox comboBoxGender1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGender2;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxGender3;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.TextBox textBoxName3;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxMemo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMemo2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.TextBox textBoxMemo3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCorrentStdNum;
        private System.Windows.Forms.CheckBox checkBoxAutoLoading;
    }
}

