﻿/// <summary>
/// Model for checkboxes.
/// </summary>
namespace bg3_mod_packer.ViewModels
{
    public class CheckBox : BaseViewModel
    {
        public string Name { get; set; }

        private bool _isSelected;
        public bool IsSelected {
            get { return _isSelected; }
            set {
                _isSelected = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}