﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
using System.Xml.Linq;

namespace Math_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, NewExecuted, CanNew));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenExecuted, CanOpen));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, SaveExecuted, CanSave));
        }

        private void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to create new file.");
        }

        private void CanNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to open existing file.");
        }

        private void CanOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to save a file.");
        }
        private void CanSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        /*private void menu_save(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }*/

        /*private void ClearExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to clear a file.");
        }
        private void CanClear(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }*/

        private void menu_clear(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do you want to Clear?");
        }

        private void menu_exit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do you want to Exit?");
        }

        private void btn_evaluate(object sender, RoutedEventArgs e)
        {
            string mathExp1 = txtName.Text.ToString();

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !txtExp.Items.Contains(txtName.Text))
            {
                txtExp.Items.Add(txtName.Text.ToString());
                txtName.Clear();
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /*private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to save a file.");
        }
        private void CanExit(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }*/
    }
}
