using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace protect_inf_LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //зашифровать
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            var p = Convert.ToInt64(TextBox_p.Text);
            var q = Convert.ToInt64(TextBox_q.Text);

            if (IsSimple(p) && IsSimple(q))
            {
                var s = TextBox_Text.Text.ToUpper();

                var n = p * q;
                var m = (p - 1) * (q - 1);
                var d = Calculate_d(m);
                var e_ = Calculate_e(d, m);

                var result = RSA_Encode(s, e_, n).ToList();

                var encodeText = result.Aggregate("", (current, item) => current + ' ' + item);

                EncodeText.Text = encodeText;

                TextBox_d.Text = d.ToString();
                TextBox_e.Text = e_.ToString();

                DecodeText.Text = RSA_Decode(result, d, n);
            }
            else
            {
                MessageBox.Show("p или q - не простые числа!");
            }
        }


        private static bool IsSimple(long number)
        {
            var isNumberSimple = true;

            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i != 0) continue;
                isNumberSimple = false;
                break;
            }

            return isNumberSimple;
        }

        //зашифровать
        private static IEnumerable<string> RSA_Encode(string s, long e, long n)
        {
            var result = new List<string>();

            foreach (var a in s)
            {
                var index = (byte) a;

                var bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int) e);

                var n_ = new BigInteger((int) n);

                bi %= n_;
                result.Add(bi.ToString("X"));
            }

            return result;
        }

        //расшифровать
        private static string RSA_Decode(IEnumerable<string> input, long d, long n)
        {
            var result = "";

            foreach (var item in input)
            {
                var bi = new BigInteger(int.Parse(item, NumberStyles.HexNumber));

                bi = BigInteger.Pow(bi, (int) d);

                var n_ = new BigInteger((int) n);

                bi %= n_;

                var index = Convert.ToByte(bi.ToString());

                result += (char) index;
            }

            return result;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private static long Calculate_d(long m)
        {
            var d = m - 1;

            for (long i = 2; i <= m; i++)
                if (m % i == 0 && d % i == 0) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        private static long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if (e * d % m == 1) break;
                e++;
            }

            return e;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var p = rnd.Next(1, int.MaxValue);
            var q = rnd.Next(1, int.MaxValue);
            while (!IsSimple(p)) p = rnd.Next(1, int.MaxValue);

            while (!IsSimple(q)) q = rnd.Next(1, int.MaxValue);

            TextBox_p.Text = p.ToString();
            TextBox_q.Text = q.ToString();
        }
    }
}