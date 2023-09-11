﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1.Converter
{
    public class BoolDisplayAddConverter : IMultiValueConverter
    {


        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == null)
                return false;

            try
            {
                int user = (int)values[0];
                if (user != -1)
                {
                    return false;
                }
            
                return false;


            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
