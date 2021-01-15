using System;
using System.Globalization;
using System.Windows.Data;

namespace ProjetoOperacoes
{
    public class ResponsiveApplicationConverter : IValueConverter
    {

        //Valor mínimo de largura 1024 a partir de valores maiores o projeto adapta as larguras dos componentes...
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }

            double firstOperand;
            double secondOperand;

            if (!double.TryParse(value.ToString(), out firstOperand))
            {
                throw new InvalidOperationException("The value could not be converted to an integer");
            }

            if (!double.TryParse(parameter.ToString(), out secondOperand))
            {
                throw new InvalidOperationException("The parameter could not be converted to an integer");
            }

            //App.ActualWidthMainWindow = System.Windows.SystemParameters.PrimaryScreenWidth;
            var largura = System.Windows.SystemParameters.PrimaryScreenWidth;

            return firstOperand > secondOperand; //parameter

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
