using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.Controls
{
    class LabeledTextBox : TextBox
    {
        public string Label 
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value); 
        }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(LabeledTextBox));

    }
}
