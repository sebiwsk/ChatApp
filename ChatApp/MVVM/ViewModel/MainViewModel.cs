﻿using ChatApp.Core;
using ChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public RelayCommand SendCommand { get; set; }
        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel() 
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username = "Allision",
                UsernameColor = "#409aff",
                ImageSource = "https://static.wikia.nocookie.net/chill-people/images/7/79/1598561227099_d41f98dc85309bb7258432ed58937f61.png/revision/latest?cb=20201204161025",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = true,
                FirstMessage = false
            });

            for (int i = 0; i < 3; i++) 
            {
                Messages.Add(new MessageModel
                {
                    Username = "Allision",
                    UsernameColor = "#409aff",
                    ImageSource = "https://static.wikia.nocookie.net/chill-people/images/7/79/1598561227099_d41f98dc85309bb7258432ed58937f61.png/revision/latest?cb=20201204161025",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Bunny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://static.wikia.nocookie.net/chill-people/images/7/79/1598561227099_d41f98dc85309bb7258432ed58937f61.png/revision/latest?cb=20201204161025",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });
            }
            Messages.Add(new MessageModel
            {
                Username = "Bunny",
                UsernameColor = "#409aff",
                ImageSource = "https://static.wikia.nocookie.net/chill-people/images/7/79/1598561227099_d41f98dc85309bb7258432ed58937f61.png/revision/latest?cb=20201204161025",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Allison {i}",
                    ImageSource = "https://static.wikia.nocookie.net/chill-people/images/7/79/1598561227099_d41f98dc85309bb7258432ed58937f61.png/revision/latest?cb=20201204161025",
                    Messages = Messages
                });
            }
        }
    }
}
