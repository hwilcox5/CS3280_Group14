﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS3280_Group14
{
    /// <summary>
    /// Interaction logic for wndEdit.xaml
    /// </summary>
    public partial class wndEdit : Window
    {
        public wndEdit()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Control how the window closes when the x is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// Instructor provided Error Handling message system
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        /*private void UpdateItem_Click(object sender, RoutedEventArgs e)
        {
            This method needs to update the selected item from the list.
            When an item is updated, the code must not be allowed to be updated (is the PK).
            Only the description and cost may be updated.
            When user closes the update definition table form, make sure to update the drop-down
            box as to reflect any changes made by the user.
            Update the current invoice because its item name might have been updated.
        }
        */

        /*private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            This method needs to remove the selected item from the list.
            Running total of the cost should be displayed as items are deleted.
            If the user tries to delete an item that is on an invoice, don't allow the user
            to do so.
            Give the user a warning message that tells them which invoices that item is used on.

        */

        /*private void AddNewItem_Click(object sender, RoutedEventArgs e)
        {
            This method needs to add an item to the list. 
            Running total of the cost should be displayed as items are entered.
        }
        */
    }
}
