using ListViewExample.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListViewExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Student> Students;

        public MainPage()
        {
            this.InitializeComponent();
            Students = StudentManager.GetStudents();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var student = (Student)e.ClickedItem;
            ResultTextBlock.Text = "You Selected: " + student.Name;
        }
    }
}
