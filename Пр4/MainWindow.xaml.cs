using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()// Конструктор
        {
            InitializeComponent();// Для окон, кнапок и текстовых полей
        }

        public bool IsPalindrome(string text)// Метод для проверки, является ли строка паличемто-там
        {
            return text == new string(text.Reverse().ToArray());// Сравниваем исходный текст с его обратной версией

        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)// Обработчик события нажатия кнопки
        {
            bool isPalindrome = IsPalindrome(i.Text);// Проверяем палиндромом

            if (isPalindrome)
            {
                qwe.Text = "Правильно!";// Это наслучай эсли я скажу что ты прав
            }
            else
            {
                qwe.Text = ":(";//Это на случай если ты как всегда не прав
            }

        }
    }
}