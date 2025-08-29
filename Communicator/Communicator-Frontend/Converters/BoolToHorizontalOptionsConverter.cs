using System.Globalization;

namespace Communicator_Frontend.Converters
{
    public class BoolToHorizontalOptionsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isIncoming = (bool)value;
            return isIncoming ? LayoutOptions.StartAndExpand : LayoutOptions.EndAndExpand;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}