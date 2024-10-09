using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_3
{
    public partial class Form1 : Form
    {
        //специальные строки для проверки вводимого текста
        string eng_string = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890\n\r ";
        string rus_string = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890\n\r ";
        int key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Viszener_Program";
        }
        static string ViszCrypt(string text, string key)
        {
            string alph_eng = "abcdefghijklmnopqrstuvwxyz";
            string alph_rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numb = "1234567890";
            string newKey = key;
            bool encode = true;
            int crypt_sign = encode ? +1 : -1; //знак для шифровки или расшифровки
            int offset;
            int indexOf;
            string result = "";
            while (newKey.Length < text.Length)
            {
                newKey += key;
            }
            if (newKey.Length > text.Length)
            {
                newKey = newKey.Substring(0, text.Length);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (alph_rus.Contains(Char.ToLower(text[i])))
                {
                    indexOf = alph_rus.IndexOf(text[i]);
                    if (indexOf != -1)
                    {
                        offset = alph_rus.IndexOf(text[i]) + alph_rus.IndexOf(newKey[i]) * crypt_sign;
                        if (offset >= alph_rus.Length)
                            offset = offset - alph_rus.Length;
                        else if (offset < 0)
                            offset = alph_rus.Length + offset;
                        result += alph_rus[offset];
                    }
                    else
                        result += text[i];
                }
                else if (alph_eng.Contains(Char.ToLower(text[i])))
                {
                    indexOf = alph_eng.IndexOf(text[i]);
                    if (indexOf != -1)
                    {
                        offset = alph_eng.IndexOf(text[i]) + alph_eng.IndexOf(newKey[i]) * crypt_sign;
                        if (offset >= alph_eng.Length)
                            offset = offset - alph_eng.Length;
                        else if (offset < 0)
                            offset = alph_eng.Length + offset;
                        result += alph_eng[offset];
                    }
                    else
                        result += text[i];
                }
                else if (numb.Contains(text[i]))
                {
                    result += text[i];
                }
                else if (text[i] == ' ')
                {
                    result += text[i];
                }
                
            }
            return result;
        }
        private void rus_CheckedChanged(object sender, EventArgs e)
        {
            if (rus.Checked == true) //проверка свойства (выбрана или нет)
            {
                eng.Checked = false; //меняем свойство другой кнопки 
                label3.Visible = false; //прячем текст об ошибке
                textBox1.Text = ""; //очистка поля
            }
            else
            {
                eng.Checked = true;
            }
        }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {
            if (eng.Checked == true)
            {
                rus.Checked = false; //меняем свойство другой кнопки 
                label3.Visible = false; //прячем текст об ошибке
                textBox1.Text = ""; //очистка поля
            }
            else
            {
                rus.Checked = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng_up = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rus_up = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            textBox1.ScrollBars = ScrollBars.Vertical; //добавление вертикального скроллбара если текст больше поля
            string text = textBox1.Text; //вытаскиваем текст для проверки
            //проверка вводимого текста
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (rus.Checked == true && !rus_string.Contains(text[i]))
                //не даем ввести все что не входит в контрольные строки
                {
                    label3.Visible = true;
                    textBox1.Text = text.Remove(text.Length - 1);
                }
                if (eng.Checked == true && !eng_string.Contains(text[i]))
                {
                    label3.Visible = true;
                    textBox1.Text = text.Remove(text.Length - 1);
                }

            }
            
            //переводим каретку в конец (точку старта ввода)
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string eng_string1 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
 
            string rus_string1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    
            string text = textBox3.Text; //извлекаем текст в поле ключа
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (rus.Checked == true && !rus_string1.Contains(text[i]))
                //не даем ввести все что не входит в контрольные строки
                {
                    label2.Visible = true;
                    textBox3.Text = text.Remove(text.IndexOf(text[i]));
                }
                if (eng.Checked == true && !eng_string1.Contains(text[i]))
                {
                    label2.Visible = true;
                    textBox3.Text = text.Remove(text.IndexOf(text[i]));
                }
            }
            
            //если совершены ошибки возвращаем каретку в конец строки
            textBox3.SelectionStart = textBox3.Text.Length;
            //присваиваем введеное число в ключ?
            if (textBox3.Text != "" && textBox3.Text != "-")
            {
                string key_string = textBox3.Text;
            }
        }

        private void crypt_Click(object sender, EventArgs e)
        {
            string str = "1234567890-";
            bool flag = false;
            string key = textBox3.Text;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (str.Contains(key[i]))
                {
                    flag = true;
                }
            }
            if (textBox3.Text != "" && flag != true && textBox1.Text != "")
            {
                string crypto_text;
                crypto_text = ViszCrypt(textBox1.Text, textBox3.Text);
                itog.Text = crypto_text;
            }
            else
            {
                label5.Visible = true;
            }
            flag = false;
        }

        static string ViszDecrypt(string text, string key)
        {
            string alph_eng = "abcdefghijklmnopqrstuvwxyz";
            string alph_rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string newKey = key;
            bool encode = false;
            int crypt_sign = encode ? +1 : -1; //знак для шифровки или расшифровки
            int offset;
            int indexOf;
            string result = "";
            while (newKey.Length < text.Length)
            {
                newKey += key;
            }
            if (newKey.Length > text.Length)
            {
                newKey = newKey.Substring(0, text.Length);
            }
            newKey = newKey.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (alph_rus.Contains(Char.ToLower(text[i])))
                {
                    indexOf = alph_rus.IndexOf(text[i]);
                    if (indexOf != -1)
                    {
                        offset = alph_rus.IndexOf(text[i]) + alph_rus.IndexOf(newKey[i]) * crypt_sign;
                        if (offset >= alph_rus.Length)
                            offset = offset - alph_rus.Length;
                        else if (offset < 0)
                            offset = alph_rus.Length + offset;
                        result += alph_rus[offset];
                    }
                    else
                        result += text[i];
                }
                else
                {
                    indexOf = alph_eng.IndexOf(text[i]);
                    if (indexOf != -1)
                    {
                        offset = alph_eng.IndexOf(text[i]) + alph_eng.IndexOf(newKey[i]) * crypt_sign;
                        if (offset >= alph_eng.Length)
                            offset = offset - alph_eng.Length;
                        else if (offset < 0)
                            offset = alph_eng.Length + offset;
                        result += alph_eng[offset];
                    }
                    else
                        result += text[i];
                }
            }
            return result;
        }
        private void decrypt_Click(object sender, EventArgs e)
        {
            string str = "1234567890-";
            bool flag = false;
            string key = textBox3.Text;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (str.Contains(key[i]))
                {
                    flag = true;
                }
            }
            if (textBox3.Text != "" && flag != true && itog.Text != "")
            {
                string crypto_text;
                crypto_text = ViszDecrypt(itog.Text, textBox3.Text);
                label6.Text = crypto_text;
            }
            else
            {
                label7.Visible = true;
            }
            flag = false;
        }
    }
}
