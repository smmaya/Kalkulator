using System;
using System.Windows;

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ?label_content;
        private double temp_number = 0;
        private double temp_number_2 = 0;
        private char temp_operation;
        private bool operation_clicked = false;
        private bool equals_operation_clicked = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "7";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "7";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "7";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "8";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "8";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "8";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "9";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "9";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "9";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "4";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "4";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "4";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "5";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "5";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "5";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "6";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "6";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "6";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "1";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "1";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "1";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "2";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "2";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "2";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "3";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "3";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "3";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (check_operation_status())
            {
                label_content = "0";
                display_results.Content = Convert.ToDouble(label_content).ToString();
            }
            else
            {
                if (equals_operation_clicked)
                {
                    label_content = "0";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                    equals_operation_clicked = false;
                }
                else
                {
                    label_content = display_results.Content.ToString();
                    label_content += "0";
                    display_results.Content = Convert.ToDouble(label_content).ToString();
                }
            }
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            display_results.Content = "0";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if(temp_number == 0)
            {
                temp_number = Convert.ToDouble(display_results.Content);
            }
            else
            {
                temp_number += Convert.ToDouble(display_results.Content);
                display_results.Content = temp_number.ToString();
            }
            temp_operation = '+';
            operation_clicked = true;
        }

        private void btn_equals_Click(object sender, RoutedEventArgs e)
        {
            if(temp_operation == '+')
            {
                if (temp_number == 0)
                {
                    temp_number = Convert.ToDouble(display_results.Content) + temp_number_2;
                }
                else {
                    temp_number += Convert.ToDouble(display_results.Content);
                    temp_number_2 = Convert.ToDouble(display_results.Content);
                }
                display_results.Content = temp_number.ToString();
            }

            else if (temp_operation == '-')
            {
                if (temp_number == 0)
                {
                    temp_number = Convert.ToDouble(display_results.Content) - temp_number_2;
                }
                else
                {
                    temp_number -= Convert.ToDouble(display_results.Content);
                    temp_number_2 = Convert.ToDouble(display_results.Content);
                }
                display_results.Content = temp_number.ToString();
            }

            else if (temp_operation == '*')
            {
                if (temp_number == 0)
                {
                    temp_number = Convert.ToDouble(display_results.Content) * temp_number_2;
                }
                else
                {
                    temp_number *= Convert.ToDouble(display_results.Content);
                    temp_number_2 = Convert.ToDouble(display_results.Content);
                }
                display_results.Content = temp_number.ToString();
            }

            else if (temp_operation == '/')
            {
                if (display_results.Content.ToString() == "0")
                {
                    temp_number = 0;
                    temp_number_2 = 0;
                    temp_operation = '\0';
                }
                else
                {
                    if (temp_number == 0)
                    {
                        temp_number = Convert.ToDouble(display_results.Content) / temp_number_2;
                    }
                    else
                    {
                        temp_number /= Convert.ToDouble(display_results.Content);
                        temp_number_2 = Convert.ToDouble(display_results.Content);
                    }
                    display_results.Content = temp_number.ToString();
                }

            }
            temp_number = 0;
            equals_operation_clicked = true;
        }

        private void btn_subs_Click(object sender, RoutedEventArgs e)
        {
            if (temp_number == 0)
            {
                temp_number = Convert.ToDouble(display_results.Content);
            }
            else
            {
                temp_number -= Convert.ToDouble(display_results.Content);
                display_results.Content = temp_number.ToString();
            }
            temp_operation = '-';
            operation_clicked = true;
        }

        private bool check_operation_status()
        {
            if (operation_clicked)
            {
                operation_clicked = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_multi_Click(object sender, RoutedEventArgs e)
        {
            if (temp_number == 0)
            {
                temp_number = Convert.ToDouble(display_results.Content);
            }
            else
            {
                temp_number *= Convert.ToDouble(display_results.Content);
                display_results.Content = temp_number.ToString();
            }
            temp_operation = '*';
            operation_clicked = true;
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            if (temp_number == 0)
            {
                temp_number = Convert.ToDouble(display_results.Content);
            }
            else
            {
                if(display_results.Content == "0")
                {
                    temp_number = 0;
                    temp_number_2 = 0;
                    temp_operation = '\0';
                    return;
                }
                temp_number /= Convert.ToDouble(display_results.Content);
                display_results.Content = temp_number.ToString();
            }
            temp_operation = '/';
            operation_clicked = true;
        }
    }
}
