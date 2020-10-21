using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLIb.model
{
    public class Record
    {
        private string _title;
        private string _artist;
        private int _duration;
        private string _yearOfPublication;
        private string _countryOrigin;
        private bool _isOnSpotify;

        public Record()
        {
        }
        public Record(string title, string artist, int duration, string yearOfPublication, string countryOrigin, bool isOnSpotify)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
            _countryOrigin = countryOrigin;
            _isOnSpotify = isOnSpotify;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public string YearOfPublication
        {
            get => _yearOfPublication;
            set => _yearOfPublication = value;
        }

        public string CountryOrigin
        {
            get => _countryOrigin;
            set => _countryOrigin = value;
        }

        public bool IsOnSpotify
        {
            get => _isOnSpotify;
            set => _isOnSpotify = value;
        }

        public override string ToString()
        {
            return $"{Title} - {Artist}";
        }
    }
}
