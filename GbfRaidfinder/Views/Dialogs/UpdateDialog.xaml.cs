using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace GbfRaidfinder.Views.Dialogs {
    /// <summary>
    ///     Interaction logic for UpdateDialog.xaml
    /// </summary>
    public partial class UpdateDialog : UserControl {
        public UpdateDialog() {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            //http://rel.sakura.ne.jp/GbfRaidfinder/GbfRaidfinder.zip
            try
            {
                Process.Start("https://rellog.hatenablog.com/entry/2019/10/06/223243");
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }
    }
}