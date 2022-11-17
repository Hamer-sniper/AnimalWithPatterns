using System.Windows;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddAnimalWindow : Window
    {
        private AddAnimalWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Диалог добавления животного
        /// </summary>
        /// <param name="repository">Репозиторий Animals</param>
        public AddAnimalWindow(Repository repository) : this()
        {
            cancelBtn.Click += delegate { this.DialogResult = false; };
            okBtn.Click += delegate
            {
                repository.Animals.Add(AnimalFactory.GetAnimal(txtType.Text, txtName.Text));
                this.DialogResult = !false;
            };
        }

    }
}
