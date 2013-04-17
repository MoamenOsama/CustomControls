using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ControlsLibrary
{
    public class MyLabel : Label
    {
        static MyLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyLabel), new FrameworkPropertyMetadata(typeof(MyLabel)));
        }
    }
}
