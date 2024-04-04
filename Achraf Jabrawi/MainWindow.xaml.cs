using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Achraf_Jabrawi
{
     {
        public MainWindow() => InitializeComponent();

    void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
            string.IsNullOrWhiteSpace(ageTextBox.Text) ||
            !int.TryParse(ageTextBox.Text, out int age) || age < 0)
        {
            MessageBox.Show(" Age must be a non-negative integer.");
            return;
        }

        
        string data = $"Name: {nameTextBox.Text}, "
                      + $"Age: {age}, "
                      + $"Height: {heightSlider.Value}, "
                      + $"Weight: {weightSlider.Value}";
        object dataListBox = null;
        dataListBox.Items.Add(data);


        object nameTextBox = null;
        nameTextBox.Clear();
        object ageTextBox = null;
        ageTextBox.Clear();
        object heightSlider = null;
        heightSlider.Value = 100;
        object weightSlider = null;
        weightSlider.Value = 30;
    }
}
}