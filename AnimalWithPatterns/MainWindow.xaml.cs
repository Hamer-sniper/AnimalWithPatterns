using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata;
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
    public partial class MainWindow : Window, IView
    {
        Presenter p;

        public string AnimalType { get; set; }

        public string AnimalName { get; set; }

        public Animal ConcreteAnimal { get; set; }

        public Repository LocalRepository { get; set; }

        /// <summary>
        /// Инициализация главного окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            p = new Presenter(this);

            LocalRepository = p.GetRepository();

            gridView.ItemsSource = p.GetBindingList();
        }

        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddClick(object sender, RoutedEventArgs e)
        {
            AddAnimalWindow add = new AddAnimalWindow(this);

            add.ShowDialog();

            if (add.DialogResult.Value)
                p.AddAnimal();
        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDeleteClick(object sender, RoutedEventArgs e)
        {
            ConcreteAnimal = (Animal)gridView.SelectedItem;
            p.RemoveAnimal();
        }

        /// <summary>
        /// Сохранить изменения ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccessGVCurrentCellChanged(object sender, EventArgs e)
        {
            p.SaveData();
        }

        /// <summary>
        /// Сохранить в TXT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemSaveToTXTClick(object sender, RoutedEventArgs e)
        {
            p.SaveToTXT();
        }

        /// <summary>
        /// Сохранить в XLSX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemSaveToXLSXClick(object sender, RoutedEventArgs e)
        {
            p.SaveToXLSX();
        }

        /// <summary>
        /// Добавить случайное животное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddRandomClick(object sender, RoutedEventArgs e)
        {
            // Просто для примера.
            AnimalType = "Random";
            AnimalName = $"Неизвестное животное {new Random().Next().ToString()}";

            p.AddRandomAnimal();
        }
    }
}
