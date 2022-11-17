using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository;

        public MainWindow()
        {
            InitializeComponent();

            Preparing();
        }

        /// <summary>
        /// Первая инициализация
        /// </summary>
        private void Preparing()
        {
            repository = RepositoryFactory.GetSQLRepository();

            //repository.Animals.Add(AnimalFactory.GetAnimal("Mammals", "Жираф"));
            //repository.Animals.Add(AnimalFactory.GetAnimal("Amphibias", "Змея"));
            //repository.Animals.Add(AnimalFactory.GetAnimal("Birds", "Попугай"));
            //repository.Animals.Add(AnimalFactory.GetAnimal("Mammals", "Пума"));
            //repository.Animals.Add(AnimalFactory.GetAnimal("Amphibias", "Черепаха"));
            //repository.Animals.Add(AnimalFactory.GetAnimal("Yeti", "Мохнатая обезьяна"));
            //repository.SaveChanges();

            repository.Animals.Load();
            gridView.ItemsSource = repository.Animals.Local.ToBindingList();
        }

        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddClick(object sender, RoutedEventArgs e)
        {
            var animal = (Animal)gridView.SelectedItem;

            AddAnimalWindow add = new AddAnimalWindow(repository);

            add.ShowDialog();

            if (add.DialogResult.Value)
            {
                repository.SaveChanges();
            }
        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDeleteClick(object sender, RoutedEventArgs e)
        {
            var animal = (Animal)gridView.SelectedItem;
            repository.Animals.Remove(animal);
        }

        /// <summary>
        /// Сохранить изменения ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccessGVCurrentCellChanged(object sender, EventArgs e)
        {
            repository.SaveChanges();
        }
    }
}
