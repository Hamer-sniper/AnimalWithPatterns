using DocumentFormat.OpenXml.Wordprocessing;
using System.Data.Entity;
using System.Windows;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddAnimalWindow : Window
    {
        public AddAnimalWindow()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Диалог добавления животного
        /// </summary>
        /// <param name="mainWindow">Главное окно</param>
        public AddAnimalWindow(MainWindow mainWindow) : this()
        {
            cancelBtn.Click += delegate { this.DialogResult = false; };
            okBtn.Click += delegate
            {
                mainWindow.AnimalType = txtType.Text;
                mainWindow.AnimalName = txtName.Text;

                this.DialogResult = !false;
            };
        }

    }
}
