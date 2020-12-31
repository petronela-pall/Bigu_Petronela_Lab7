using System;
using System.Collections.Generic;
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
using System.Data.Entity;
using AutoLotModel;

namespace Bigu_Petronela_Lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     enum ActionState {
             New,    
             Edit, 
             Delete, 
             Nothing
        }
public partial class MainWindow : Window
    {
        ActionState action = ActionState.Nothing;
        AutoLotEntitiesModel ctx = new AutoLotEntitiesModel(); 
        CollectionViewSource customerViewSource;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource"))); 
            customerViewSource.Source = ctx.Customers.Local; ctx.Customers.Load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
                action = ActionState.New;
                btnNew.IsEnabled = false;
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;

                btnSave.IsEnabled = true;
                btnCancel.IsEnabled = true;
                custIdTextBox.IsEnabled = false;
                btnPrev.IsEnabled = false;
                btnNext.IsEnabled = false;
                firstNameTextBox.IsEnabled = true;
                lastNameTextBox.IsEnabled = true;
                BindingOperations.ClearBinding(lastNameTextBox, TextBox.TextProperty);
                BindingOperations.ClearBinding(firstNameTextBox, TextBox.TextProperty);
                lastNameTextBox.Text = "";
                firstNameTextBox.Text = "";
                //Keyboard.Focus(txtPhoneNumber);
            }
        }
 }

