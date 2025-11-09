using System;
using System.Windows;

namespace WPFArena.StandardControls;

public partial class TextControlDemo : Window
{
    public TextControlDemo()
    {
        InitializeComponent();
    }
    
    void OnSubmitCommentsClick(object sender, EventArgs e)
    {
        MessageBox.Show(string.Format("User: {0}, Comment: {1}{2}", _name.Text, Environment.NewLine, _comment.Text));
    }
}