using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserList userList;
        public MainWindow()
        {
            InitializeComponent();
            userList = UserList.getInstance();
        }
    }

    class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string IdNumber { get; set; }
        public string ImagePath { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string SigupDate { get; set; }
        public int Liked { get; set; }
        public int Disliked { get; set; }
        public int Posts { get; set; }
        public int Following { get; set; }
        public int Follower { get; set; }

        public UserInfo(string name, string surname, string telephone, string idNumber, string imagePath, int age, string gender, string status, string sigupDate, int liked, int disliked, int posts, int following, int follower)
        {
            Name = name;
            Surname = surname;
            Telephone = telephone;
            IdNumber = Guid.NewGuid().ToString();
            ImagePath = imagePath;
            Age = age;
            Gender = gender;
            Status = status;
            SigupDate = sigupDate;
            Liked = liked;
            Disliked = disliked;
            Posts = posts;
            Following = following;
            Follower = follower;
        }
    }

    class UserList
    {
        List<UserInfo> userlist;
        public UserList()
        {
            userlist = new List<UserInfo>();
        }

        static UserList Users = new UserList();

        public static UserList getInstance()
        {
            return Users;
        }

        public void AddUser(string name, string surname, string telephone, string idNumber, string imagePath, int age, string gender, string status, string sigupDate, int liked, int disliked, int posts, int following, int follower)
        {
            userlist.Add(new UserInfo(name, surname, telephone, idNumber, imagePath, age, gender, status, sigupDate, liked, disliked, posts, following, follower));
        }

        public void RemoveUser(string uid)
        {
            foreach (var item in userlist)
            {
                if (item.IdNumber.Equals(uid))
                {
                    userlist.Remove(item);
                }
            }
        }

        public UserInfo Find(string uid)
        {
            foreach (var item in userlist)
            {
                if (item.IdNumber.Equals(uid))
                {
                    return item;
                }
            }
            return null;
        }

        public List<UserInfo> GetList()
        {
            return userlist;
        }
    }
}
