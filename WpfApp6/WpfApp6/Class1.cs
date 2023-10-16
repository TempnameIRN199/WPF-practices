using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;

namespace WpfApp6
{
    public class kuma
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public string Address { get; set; }

        public kuma()
        {
            Name = "";
            Age = 0;
            Address = "";
        }
    }

    public class PositivePriceRule : ValidationRule
    {
        private decimal min = 0;
        private decimal max = Decimal.MaxValue;

        public decimal Min
        {
            get { return min; }
            set { min = value; }
        }

        public decimal Max
        {
            get { return max; }
            set { max = value; }
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            decimal price = 0;
            try
            {
                price = Decimal.Parse((string)value, NumberStyles.Any, cultureInfo);
            }
            catch
            {
                return new ValidationResult(false, "Неприпустимі символи");
            }
            if ((price < Min) || (price > Max))
            {
                return new ValidationResult(false, "Поза діапазоном");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
