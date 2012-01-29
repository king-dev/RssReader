﻿using System;
using System.Windows;
using System.Windows.Data;

namespace Reader.Converters
{
    public class BoolToVisiblityConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var theTruth = (bool)value;
            return theTruth ? Visibility.Visible : Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
