using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Zadanie3
{
    public class MediaViewModel : INotifyPropertyChanged
    {
        private MediaItem? _selectedMediaItem;

        public ObservableCollection<MediaItem> MediaItems { get; set; }
        public MediaItem? SelectedMediaItem
        {
            get => _selectedMediaItem;
            set
            {
                _selectedMediaItem = value;
                OnPropertyChanged(nameof(SelectedMediaItem));
            }
        }

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand ExportCommand { get; }

        public MediaViewModel()
        {
            MediaItems = new ObservableCollection<MediaItem>();
            AddCommand = new RelayCommand(AddMediaItem);
            EditCommand = new RelayCommand(EditMediaItem, CanEditOrDelete);
            DeleteCommand = new RelayCommand(DeleteMediaItem, CanEditOrDelete);
            ImportCommand = new RelayCommand(ImportMediaItems);
            ExportCommand = new RelayCommand(ExportMediaItems);
        }

        private void AddMediaItem(object? parameter)
        {
            var newItem = new MediaItem();
            var editWindow = new EditWindow(newItem);
            if (editWindow.ShowDialog() == true)
            {
                MediaItems.Add(newItem);
            }
        }

        private void EditMediaItem(object? parameter)
        {
            if (SelectedMediaItem != null)
            {
                var editWindow = new EditWindow(SelectedMediaItem);
                editWindow.ShowDialog();
            }
        }

        private void DeleteMediaItem(object? parameter)
        {
            if (SelectedMediaItem != null)
            {
                MediaItems.Remove(SelectedMediaItem);
            }
        }

        private bool CanEditOrDelete(object? parameter)
        {
            return SelectedMediaItem != null;
        }

        private void ImportMediaItems(object? parameter)
        {

            MessageBox.Show("Import jeszcze nie działa.");
        }

        private void ExportMediaItems(object? parameter)
        {
            MessageBox.Show("Export jeszcze nie działa.");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
