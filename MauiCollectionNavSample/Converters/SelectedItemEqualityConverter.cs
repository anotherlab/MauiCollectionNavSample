using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace MauiCollectionNavSample.Converters
{
    public class SelectedItemEqualityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // value: the item in the template
            // parameter: the CollectionView (passed as x:Reference)
            if (parameter is CollectionView collectionView)
            {
                return object.Equals(value, collectionView.SelectedItem);
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}