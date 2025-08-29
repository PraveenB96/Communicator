using System.Globalization;

namespace Communicator_Frontend.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isIncoming = (bool)value;

            // Teams style colors
            if (!isIncoming)
                return Color.FromRgb(232, 240, 254);   // Light blue for incoming
            else
                return Color.FromRgb(243, 243, 243);   // Light gray for outgoing
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}