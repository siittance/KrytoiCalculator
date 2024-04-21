using KrytoiKalculator.Model;
using KrytoiKalculator.ViewModel.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace KrytoiKalculator.ViewModel
{
    internal class ModelView : Helpers
    {
        private model selected;
        public model Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        #region Команды
        private StringBuilder stringBuilder = new StringBuilder();
        public DlyaKnopki AddLeftSkobka { get; set; }
        #endregion
    }
}  