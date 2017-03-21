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

namespace pv_code_challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ///Outstanding: Create a method to pass in a parameter for "Register" or "Diagnose
                ///Outstanding: If/else/else if statement for "Register," "Diagnose," or else parameter
                    ///Register code:
                    ///For loop through numbers 1 to 100
                    for (int i = 1; i <= 100; i++)
                    {
                        ///Logic to replace numbers divisible by 3 and 5
                        if (i % 3 == 0 & i % 5 == 0)
                        {
                            ///Logic to replace number with "Register Patient" string.
                            ///Outstanding: Print to Window
                            Console.WriteLine("Register Patient");
                        }
                        ///Logic to identify numbers divisible by 3
                        else if (i % 3 == 0)
                        {
                            ///Logic to replace number with "Register" string
                            ///Outstanding: Print to Window
                            Console.WriteLine("Register");
                        }
                        ///Logic to replace numbers divisible by 5
                        else if (i % 5 == 0)
                        {
                            ///Logic to replace number with "Patient" string
                            ///Outstanding: Print to Window
                            Console.WriteLine("Patient");
                        }

                        else
                        {
                            ///Logic to print number
                            ///Outstanding: Print to Window
                            Console.WriteLine(i);
                        }
                    }

                    ///Diagnose code:
                    ///For loop through numbers 1 to 100
                    for (int i = 1; i <= 100; i++)
                    {
                        ///Logic to replace numbers divisible by 2 and 7
                        if (i % 2 == 0 & i % 7 == 0)
                        {
                        ///Logic to replace number with "Diagnose Patient" string
                        ///Outstanding: Print to Window
                        Console.WriteLine("Diagnose Patient");
                        }
                        ///Logic to identify numbers divisible by 2
                        else if (i % 2 == 0)
                        {
                        ///Logic to replace number with "Diagnose" string
                        ///Outstanding: Print to Window
                        Console.WriteLine("Diagnose");
                        }
                        ///Logic to replace numbers divisible by 7
                        else if (i % 7 == 0)
                        {
                        ///Logic to replace number with "Patient" string
                        ///Outstanding: Print to Window
                        Console.WriteLine("Patient");
                        }

                        else
                        {
                        ///Logic to print number
                        ///Outstanding: Print to Window
                        Console.WriteLine(i);
                        }
                    }
        }
    }

}
