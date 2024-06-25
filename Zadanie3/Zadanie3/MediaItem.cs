using System;
using System.ComponentModel;

namespace Zadanie3
{
    public class MediaItem : INotifyPropertyChanged
    {
        private string? _tytul;
        private string? _autorRezyser;
        private string? _wydawcaStudio;
        private string? _nosnik;
        private DateTime _dataWydania;
        private TimeSpan _dlugosc;

        public string? Tytul
        {
            get => _tytul;
            set
            {
                _tytul = value;
                OnPropertyChanged(nameof(Tytul));
            }
        }

        public string? AutorRezyser
        {
            get => _autorRezyser;
            set
            {
                _autorRezyser = value;
                OnPropertyChanged(nameof(AutorRezyser));
            }
        }

        public string? WydawcaStudio
        {
            get => _wydawcaStudio;
            set
            {
                _wydawcaStudio = value;
                OnPropertyChanged(nameof(WydawcaStudio));
            }
        }

        public string? Nosnik
        {
            get => _nosnik;
            set
            {
                _nosnik = value;
                OnPropertyChanged(nameof(Nosnik));
            }
        }

        public DateTime DataWydania
        {
            get => _dataWydania;
            set
            {
                _dataWydania = value;
                OnPropertyChanged(nameof(DataWydania));
            }
        }

        public TimeSpan Dlugosc
        {
            get => _dlugosc;
            set
            {
                _dlugosc = value;
                OnPropertyChanged(nameof(Dlugosc));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
