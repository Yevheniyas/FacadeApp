using FacadeFactory;
using System;
using System.Windows.Forms;

namespace FacadeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заповнюємо ComboBox стилями фасадів
            cmbFacadeStyles.Items.Add("Classic");
            cmbFacadeStyles.Items.Add("Modern");
            cmbFacadeStyles.Items.Add("Gothic");

            // Встановлюємо початковий вибір
            cmbFacadeStyles.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо вибір користувача
            string selectedStyle = cmbFacadeStyles.SelectedItem.ToString();

            // Створюємо відповідного майстра залежно від вибору
            FacadeMaster master;

            switch (selectedStyle)
            {
                case "Classic":
                    master = new ClassicMaster();
                    break;
                case "Modern":
                    master = new ModernMaster();
                    break;
                case "Gothic":
                    master = new GothicMaster();
                    break;
                default:
                    master = new ClassicMaster();
                    break;
            }

            // Викликаємо метод BuildFacade для створення фасаду
            master.BuildFacade();

            // Виводимо результат у Label
            lblResult.Text = $"You selected {selectedStyle} style for facade.";
        }
    }
}
