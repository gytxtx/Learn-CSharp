using System;
using System.Windows.Data;
using System.Windows.Media;

namespace KMCL
{
    public class SolidColorBrushOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is SolidColorBrush brush && parameter != null)
            {
                // 将参数转换为字符串并解析为 double
                if (double.TryParse(parameter.ToString(), out double opacity))
                {
                    byte alpha = (byte)(opacity * 255);
                    return new SolidColorBrush(Color.FromArgb(alpha, brush.Color.R, brush.Color.G, brush.Color.B));
                }
            }
            return value; // 转换失败时返回原值
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
