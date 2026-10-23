using System;
using System.ComponentModel;

namespace baiktraso2
{
    public class MemberModel : INotifyPropertyChanged
    {
        private string memberId;
        private string fullName;
        private string phone;
        private string package;
        private DateTime startDate;
        private decimal fee;

        public string MemberId
        {
            get => memberId;
            set { memberId = value; OnPropertyChanged(nameof(MemberId)); }
        }

        public string FullName
        {
            get => fullName;
            set { fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        public string Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        public string Package
        {
            get => package;
            set { package = value; OnPropertyChanged(nameof(Package)); }
        }

        public DateTime StartDate
        {
            get => startDate;
            set { startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }

        public decimal Fee
        {
            get => fee;
            set { fee = value; OnPropertyChanged(nameof(Fee)); }
        }

        public MemberModel() { }

        public MemberModel(string memberId, string fullName, string phone, string package, DateTime startDate, decimal fee)
        {
            MemberId = memberId;
            FullName = fullName;
            Phone = phone;
            Package = package;
            StartDate = startDate;
            Fee = fee;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}