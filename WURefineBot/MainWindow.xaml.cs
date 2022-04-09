using System;
using System.Collections.Generic;
using System.Drawing;
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
using WURefineBot.Core.Interfaces.Services;
using WURefineBot.Infrastructure.AI;

namespace WURefineBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRefineService _refineService;

        public MainWindow(IRefineService refineService)
        {
            InitializeComponent();
            _refineService = refineService;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _refineService.ExecuteRefine(WURefineBot.Core.Enums.Resources.Darkonit);
        }
    }
}
