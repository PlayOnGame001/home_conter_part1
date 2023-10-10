using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace home_conter_part1
{
    class User
    {
        private MainWindow _view;
        private Model _model;

        public User(MainWindow view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void ButtonClicked(string buttonText)
        {
            string currentText = _view.textBlock.Text;
            string updatedText = currentText + buttonText;
            _view.UpdateTextBlock(updatedText);
        }

        public void ButtonClear()
        {
            _view.UpdateTextBlock(string.Empty);
        }

        public void OKButtonClicked()
        {
            MessageBox.Show("Good");
        }
    }
}
