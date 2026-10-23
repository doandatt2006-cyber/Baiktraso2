using System;
using System.ComponentModel;

namespace baiktraso2
{
    public class BookModel : INotifyPropertyChanged
    {
        private string bookId;
        private string title;
        private decimal price;
        private int quantity;
        private string coverPath;

        public string BookId
        {
            get => bookId;
            set { bookId = value; OnPropertyChanged(nameof(BookId)); }
        }

        public string Title
        {
            get => title;
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }

        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public string CoverPath
        {
            get => coverPath;
            set { coverPath = value; OnPropertyChanged(nameof(CoverPath)); }
        }

        // Tự động tính Tổng giá trị = Giá * Số lượng
        public decimal TotalValue => Price * Quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}