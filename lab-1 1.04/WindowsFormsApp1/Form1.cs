using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, StringBuilder lParam);

        private const uint WM_CLOSE = 0x0010;
        private const uint WM_SETTEXT = 0x000C;

        private IntPtr targetWindowHandle = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
            // Добавление элементов в comboBoxAction, если не задано в Designer
            if (comboBoxAction.Items.Count == 0)
            {
                comboBoxAction.Items.Add("Изменить заголовок");
                comboBoxAction.Items.Add("Закрыть окно");
            }
            comboBoxAction.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string windowTitle = textBoxWindowTitle.Text;
            targetWindowHandle = FindWindow(null, windowTitle);

            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Окно не найдено.");
            }
            else
            {
                MessageBox.Show("Окно найдено.");
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Окно не выбрано. Пожалуйста, найдите окно перед выполнением действий.");
                return;
            }

            // Проверка на null и выполнение действия
            string action = comboBoxAction.SelectedItem?.ToString();
            if (action == "Изменить заголовок")
            {
                string newTitle = textBoxNewTitle.Text;
                if (string.IsNullOrWhiteSpace(newTitle))
                {
                    MessageBox.Show("Введите новый заголовок.");
                    return;
                }
                SetWindowTitle(targetWindowHandle, newTitle);
                MessageBox.Show("Заголовок окна изменен.");
            }
            else if (action == "Закрыть окно")
            {
                CloseWindow(targetWindowHandle);
                MessageBox.Show("Окно закрыто.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите действие.");
            }
        }

        private void SetWindowTitle(IntPtr hWnd, string title)
        {
            SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, new StringBuilder(title));
        }

        private void CloseWindow(IntPtr hWnd)
        {
            SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
