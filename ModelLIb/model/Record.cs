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
        private string _countryorigin;

        public Record()
        {
        }

        public Record(string title, string artist, int duration, string yearOfPublication, string countryorigin)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
            _countryorigin = countryorigin;
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

        public string Countryorigin
        {
            get => _countryorigin;
            set => _countryorigin = value;
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Duration)}: {Duration}, {nameof(YearOfPublication)}: {YearOfPublication}, {nameof(Countryorigin)}: {Countryorigin}";
        }
    }

}
