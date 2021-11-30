using System;
using System.Windows.Forms;

namespace AASCal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        static char[] arrSS =
                {
                '0',  '1',
                '2',   '3',   '4',   '5',   '6',   '7',
                '8',   '9',   'a',   'b',   'c',   'd',
                'e',   'f',   'g',   'h',   'i',   'j',
                'k',   'l',   'm',   'n',   'o',   'p',
                'q',   'r',   's',   't',   'u',   'v',
                'w',   'x',   'y',   'z',
                };
        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 36; i++)
            {//инициализация полей ввода СС
                CmBoxSSNum1.Items.Add(i);
                CmBoxSSNum2.Items.Add(i);
                CmBSSRes.Items.Add(i);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnGetRes_Click(object sender, EventArgs e)
        {
            string num1, num2;

            if (!CheckDigitOrLetter(TxBNum1.Text) || !CheckDigitOrLetter(TxBNum2.Text))
            {//проверка правильности ввода чисел
                return;
            }
            else
            {
                num1 = TxBNum1.Text;
                num2 = TxBNum2.Text;
            }

            if (CheckSysSch(CmBoxSSNum1.Text) && CheckSysSch(CmBoxSSNum2.Text) && CheckSysSch(CmBSSRes.Text))
            { }//проверка ввода сис. счисл.
            else
            {
                return;
            }


            double n1, n2;

            if (RadBtnAddition.Checked)
            {
                n1 = MainBlog(num1, Convert.ToInt32(CmBoxSSNum1.Text));
                n2 = MainBlog(num2, Convert.ToInt32(CmBoxSSNum2.Text));
                try
                {
                    string res = GetNumValueInAnySystem(n1 + n2, int.Parse(CmBSSRes.Text));
                    TxBViewRes.Text = strRevers(res).ToUpper();
                }
                catch { };
            }
            else
            {
                n1 = MainBlog(num1, Convert.ToInt32(CmBoxSSNum1.Text));
                n2 = MainBlog(num2, Convert.ToInt32(CmBoxSSNum2.Text));
                try
                {
                    string res = GetNumValueInAnySystem(n1 * n2, int.Parse(CmBSSRes.Text));
                    TxBViewRes.Text = strRevers(res).ToUpper();
                }
                catch { };
            }
        }
        private static double MainBlog(string num, int SS)
        {
            double res = 0;
            int stepeni = num.Length - 1;
            bool outsideSS = false;
            for (int i = 0; i < num.Length; i++)
            {
                double undoRes = GetNumValue(num[i], arrSS, SS, ref outsideSS) * Math.Pow(SS, stepeni);
                if (outsideSS == true)
                {
                    MessageBox.Show("Не корректное число, для этой СС");
                    break;
                }
                res += undoRes;
                stepeni--;
            }
            return res;
        }
        private static string GetNumValueInAnySystem(double num, int ss)
        {
            string res = null;
            int ostatok;
            while (num != 0)
            {
                ostatok = (int)(num % ss);
                num = (num - ostatok) / ss;
                res += arrSS[ostatok];

            }
            return res;
        }

        private static double GetNumValue(char v, char[] arrSS, int ss, ref bool outsideSS)
        {
            v = char.ToLower(v);

            if (v >= 'a' && v <= 'z' || v >= '0' && v <= '9')
            {
                for (int i = 0; i < 36; i++)
                {
                    if (i >= ss)
                    {
                        MessageBox.Show($"Число {v} отсутсвует в системе счисления {ss}");
                        outsideSS = true;
                        return 0;
                    }
                    else
                    {
                        if (v == arrSS[i])
                        {
                            return i;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }

            return Convert.ToInt32(v);
        }

        private static string strRevers(string str)
        {
            string input = str;
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            return output;
        }

        private void BtnTo10_Click(object sender, EventArgs e)
        {
            if (!CheckDigitOrLetter(TxBN1To10.Text))
            {
                return;
            }
            double res;
            try
            {
                res = MainBlog(TxBN1To10.Text, 2);
            }
            catch
            {
                MessageBox.Show("Не корреный ввод");
                return;
            }
            TxBN2To10.Text = Convert.ToString(res);
        }

        private void BtnTo2_Click(object sender, EventArgs e)
        {
            if (!CheckDigitOrLetter(TxBN1To2.Text))
            {
                return;
            }
            try
            {
                TxBN2To2.Text = strRevers(GetNumValueInAnySystem(Convert.ToDouble(TxBN1To2.Text), 2));
            }
            catch
            {
                MessageBox.Show("Не корреный ввод");
                return;
            }
        }
        private bool CheckDigitOrLetter(string s)
        {
            if (s.Length <= 0 )
            {
                MessageBox.Show("Вы не ввели одно из чисел");
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= '0' && s[i] <= '9'||s[i]==',')
                { }
                else
                {
                    MessageBox.Show("Нет такой буквы!");
                    return false;
                }
            }
            return true;
        }
        private bool CheckSysSch(string s)
        {
            try
            {
                if (Convert.ToInt32(s) >= 2 && Convert.ToInt32(s) <= 36)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка в вводе системы сисления");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в вводе системы сисления");
                return false;
            }
        }
    }
}
