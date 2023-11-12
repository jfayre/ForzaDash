using System.ComponentModel;

namespace forzaDash
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        private float _rpm;
        private float _tireTemperature;
        private double _speed;
        private int _lapNumber;
        private int _position;

        public float RPM
        {
            get => _rpm;
            set
            {
                if (_rpm != value)
                {
                    _rpm = value;
                    OnPropertyChanged(nameof(RPM));
                }
            }
        }

        public float TireTemperature
        {
            get => _tireTemperature;
            set
            {
                if (_tireTemperature != value)
                {
                    _tireTemperature = value;
                    OnPropertyChanged(nameof(TireTemperature));
                }
            }
        }

        public double Speed
        {
            get => _speed;
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                    OnPropertyChanged(nameof(Speed));
                }
            }
        }

        public int LapNumber
        {
            get => _lapNumber;
            set
            {
                if (_lapNumber != value)
                {
                    _lapNumber = value;
                    OnPropertyChanged(nameof(LapNumber));
                }
            }
        }

        public int Position
        {
            get => _position;
            set
            {
                if (_position != value)
                {
                    _position = value;
                    OnPropertyChanged(nameof(Position));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}