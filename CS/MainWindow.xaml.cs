using System;
using System.Windows;
using System.Windows.Data;
using DevExpress.XtraScheduler;

namespace SchedulerBindLimitIntervalWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class IntervalConverter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            DateTime start = (DateTime)values[0];
            DateTime end = (DateTime)values[1];

            if (start > end)
                start = end;

            return new TimeInterval(start, end);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

}
