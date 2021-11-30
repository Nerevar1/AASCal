
namespace AASCal
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxBViewRes = new System.Windows.Forms.TextBox();
            this.BtnGetRes = new System.Windows.Forms.Button();
            this.TxBNum1 = new System.Windows.Forms.TextBox();
            this.TxBNum2 = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.RadBtnAddition = new System.Windows.Forms.RadioButton();
            this.RadBtnMultiplication = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmBoxSSNum1 = new System.Windows.Forms.ComboBox();
            this.CmBoxSSNum2 = new System.Windows.Forms.ComboBox();
            this.CmBSSRes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxBN1To10 = new System.Windows.Forms.TextBox();
            this.TxBN2To10 = new System.Windows.Forms.TextBox();
            this.BtnTo10 = new System.Windows.Forms.Button();
            this.BtnTo2 = new System.Windows.Forms.Button();
            this.TxBN2To2 = new System.Windows.Forms.TextBox();
            this.TxBN1To2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxBViewRes
            // 
            this.TxBViewRes.Location = new System.Drawing.Point(12, 195);
            this.TxBViewRes.Name = "TxBViewRes";
            this.TxBViewRes.Size = new System.Drawing.Size(399, 20);
            this.TxBViewRes.TabIndex = 9;
            // 
            // BtnGetRes
            // 
            this.BtnGetRes.Location = new System.Drawing.Point(204, 166);
            this.BtnGetRes.Name = "BtnGetRes";
            this.BtnGetRes.Size = new System.Drawing.Size(75, 23);
            this.BtnGetRes.TabIndex = 7;
            this.BtnGetRes.Text = "=";
            this.BtnGetRes.UseVisualStyleBackColor = true;
            this.BtnGetRes.Click += new System.EventHandler(this.BtnGetRes_Click);
            // 
            // TxBNum1
            // 
            this.TxBNum1.Location = new System.Drawing.Point(12, 46);
            this.TxBNum1.Name = "TxBNum1";
            this.TxBNum1.Size = new System.Drawing.Size(153, 20);
            this.TxBNum1.TabIndex = 1;
            // 
            // TxBNum2
            // 
            this.TxBNum2.Location = new System.Drawing.Point(258, 46);
            this.TxBNum2.Name = "TxBNum2";
            this.TxBNum2.Size = new System.Drawing.Size(153, 20);
            this.TxBNum2.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(390, 337);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // RadBtnAddition
            // 
            this.RadBtnAddition.AutoSize = true;
            this.RadBtnAddition.Location = new System.Drawing.Point(203, 104);
            this.RadBtnAddition.Name = "RadBtnAddition";
            this.RadBtnAddition.Size = new System.Drawing.Size(76, 17);
            this.RadBtnAddition.TabIndex = 5;
            this.RadBtnAddition.TabStop = true;
            this.RadBtnAddition.Text = "Сложение";
            this.RadBtnAddition.UseVisualStyleBackColor = true;
            // 
            // RadBtnMultiplication
            // 
            this.RadBtnMultiplication.AutoSize = true;
            this.RadBtnMultiplication.Location = new System.Drawing.Point(203, 127);
            this.RadBtnMultiplication.Name = "RadBtnMultiplication";
            this.RadBtnMultiplication.Size = new System.Drawing.Size(85, 17);
            this.RadBtnMultiplication.TabIndex = 6;
            this.RadBtnMultiplication.TabStop = true;
            this.RadBtnMultiplication.Text = "Умножение";
            this.RadBtnMultiplication.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Число 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Число 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Действие";
            // 
            // CmBoxSSNum1
            // 
            this.CmBoxSSNum1.FormattingEnabled = true;
            this.CmBoxSSNum1.Location = new System.Drawing.Point(171, 46);
            this.CmBoxSSNum1.Name = "CmBoxSSNum1";
            this.CmBoxSSNum1.Size = new System.Drawing.Size(65, 21);
            this.CmBoxSSNum1.TabIndex = 2;
            // 
            // CmBoxSSNum2
            // 
            this.CmBoxSSNum2.FormattingEnabled = true;
            this.CmBoxSSNum2.Location = new System.Drawing.Point(417, 46);
            this.CmBoxSSNum2.Name = "CmBoxSSNum2";
            this.CmBoxSSNum2.Size = new System.Drawing.Size(48, 21);
            this.CmBoxSSNum2.TabIndex = 4;
            // 
            // CmBSSRes
            // 
            this.CmBSSRes.FormattingEnabled = true;
            this.CmBSSRes.Location = new System.Drawing.Point(417, 194);
            this.CmBSSRes.Name = "CmBSSRes";
            this.CmBSSRes.Size = new System.Drawing.Size(48, 21);
            this.CmBSSRes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cист. Счил.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cист. Счил.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cист. Счил.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Из 2 в 10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Из 10 в 2";
            // 
            // TxBN1To10
            // 
            this.TxBN1To10.Location = new System.Drawing.Point(18, 267);
            this.TxBN1To10.Name = "TxBN1To10";
            this.TxBN1To10.Size = new System.Drawing.Size(100, 20);
            this.TxBN1To10.TabIndex = 10;
            // 
            // TxBN2To10
            // 
            this.TxBN2To10.Location = new System.Drawing.Point(171, 267);
            this.TxBN2To10.Name = "TxBN2To10";
            this.TxBN2To10.Size = new System.Drawing.Size(100, 20);
            this.TxBN2To10.TabIndex = 12;
            // 
            // BtnTo10
            // 
            this.BtnTo10.Location = new System.Drawing.Point(125, 264);
            this.BtnTo10.Name = "BtnTo10";
            this.BtnTo10.Size = new System.Drawing.Size(40, 23);
            this.BtnTo10.TabIndex = 11;
            this.BtnTo10.Text = "->";
            this.BtnTo10.UseVisualStyleBackColor = true;
            this.BtnTo10.Click += new System.EventHandler(this.BtnTo10_Click);
            // 
            // BtnTo2
            // 
            this.BtnTo2.Location = new System.Drawing.Point(125, 303);
            this.BtnTo2.Name = "BtnTo2";
            this.BtnTo2.Size = new System.Drawing.Size(40, 23);
            this.BtnTo2.TabIndex = 14;
            this.BtnTo2.Text = "->";
            this.BtnTo2.UseVisualStyleBackColor = true;
            this.BtnTo2.Click += new System.EventHandler(this.BtnTo2_Click);
            // 
            // TxBN2To2
            // 
            this.TxBN2To2.Location = new System.Drawing.Point(171, 306);
            this.TxBN2To2.Name = "TxBN2To2";
            this.TxBN2To2.Size = new System.Drawing.Size(100, 20);
            this.TxBN2To2.TabIndex = 15;
            // 
            // TxBN1To2
            // 
            this.TxBN1To2.Location = new System.Drawing.Point(19, 305);
            this.TxBN1To2.Name = "TxBN1To2";
            this.TxBN1To2.Size = new System.Drawing.Size(100, 20);
            this.TxBN1To2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "*Дробные числа не поддерживаются";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 381);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnTo2);
            this.Controls.Add(this.TxBN2To2);
            this.Controls.Add(this.TxBN1To2);
            this.Controls.Add(this.BtnTo10);
            this.Controls.Add(this.TxBN2To10);
            this.Controls.Add(this.TxBN1To10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmBSSRes);
            this.Controls.Add(this.CmBoxSSNum2);
            this.Controls.Add(this.CmBoxSSNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadBtnMultiplication);
            this.Controls.Add(this.RadBtnAddition);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxBNum2);
            this.Controls.Add(this.TxBNum1);
            this.Controls.Add(this.BtnGetRes);
            this.Controls.Add(this.TxBViewRes);
            this.Name = "MainForm";
            this.Text = "Калькулятор систем счисления";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBViewRes;
        private System.Windows.Forms.Button BtnGetRes;
        private System.Windows.Forms.TextBox TxBNum1;
        private System.Windows.Forms.TextBox TxBNum2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RadioButton RadBtnAddition;
        private System.Windows.Forms.RadioButton RadBtnMultiplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmBoxSSNum1;
        private System.Windows.Forms.ComboBox CmBoxSSNum2;
        private System.Windows.Forms.ComboBox CmBSSRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxBN1To10;
        private System.Windows.Forms.TextBox TxBN2To10;
        private System.Windows.Forms.Button BtnTo10;
        private System.Windows.Forms.Button BtnTo2;
        private System.Windows.Forms.TextBox TxBN2To2;
        private System.Windows.Forms.TextBox TxBN1To2;
        private System.Windows.Forms.Label label9;
    }
}

