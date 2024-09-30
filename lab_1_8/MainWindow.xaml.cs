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

namespace lab_1_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateIntegral()
        {
            double upperBound = Convert.ToDouble(tbUpperBound.Text);
            double lowerBound = Convert.ToDouble(tbLowerBound.Text);
            int count = Convert.ToInt32(tbPartCount.Text);
            ICalculatorIntegral calculatorIntegralT = new TrapezoidCalculator();
            double outputTrap = calculatorIntegralT.Calculate(upperBound, lowerBound, count, x=>(2*x - Math.Log(11*x)-1));
            tbMethodTrapezoid.Text = Convert.ToString(outputTrap);
            ICalculatorIntegral calculatorIntegralS = new SimpsonCalculator();
            double outputSim = calculatorIntegralS.Calculate(upperBound, lowerBound, count, x => (2 * x - Math.Log(11 * x) - 1));
            tbMethodSimpson.Text = Convert.ToString(outputSim);

        }

        private ICalculatorIntegral GetCalculator()
        {
            switch (cmbBoxIntegralType.SelectedIndex)
            {
                case 0:
                    return new TrapezoidCalculator();
                case 1:
                    return new SimpsonCalculator();
                default:
                    return;
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateIntegral();
        }
    }
}
