using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace booksys
{
    public class User
    {
        private String uid;
        private String username;
        private String phone;
        private String sex;
        private String email;
        private String major;
        private String password;
        private Boolean isAdmin;
        private Boolean isBlack;

        public User()
        {
        }

        public User(string uid, string username, string phone, string sex, string email, string major, string password, Boolean isAdmin, Boolean isBlack)
        {
            this.uid = uid;
            this.username = username;
            this.phone = phone;
            this.sex = sex;
            this.email = email;
            this.major = major;
            this.password = password;
            this.isAdmin = isAdmin;
            this.isBlack = isBlack;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Username { get => username; set => username = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Email { get => email; set => email = value; }
        public string Major { get => major; set => major = value; }
        public string Password { get => password; set => password = value; }
        public Boolean IsAdmin { get => isAdmin; set => isAdmin = value; }
        public Boolean IsBlack { get => isBlack; set => isBlack = value; }

        public static User ToBean(SqlDataReader reader)
        {
            User user = null;
            if (reader.Read())
            {
                user = new User(reader["uid"].ToString(), reader["username"].ToString(), reader["phone"].ToString(), reader["sex"].ToString(), reader["email"].ToString(),
                    reader["major"].ToString(), reader["password"].ToString(), Convert.ToBoolean(reader["isAdmin"].ToString()), Convert.ToBoolean(reader["isBlack"]));

            }
            return user;
        }

        public static List<User> ToBeanList(SqlDataReader reader)
        {
            User user = null;
            List<User> list = new List<User>();
            while (reader.Read())
            {
                user = new User(reader["uid"].ToString(), reader["username"].ToString(), reader["phone"].ToString(), reader["sex"].ToString(), reader["email"].ToString(),
                    reader["major"].ToString(), reader["password"].ToString(), Convert.ToBoolean(reader["isAdmin"].ToString()), Convert.ToBoolean(reader["isBlack"]));
                list.Add(user);
            }
            return list;
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   //uid == user.uid &&
                   //username == user.username &&
                   //phone == user.phone &&
                   //sex == user.sex &&
                   //email == user.email &&
                   //major == user.major &&
                   //password == user.password &&
                   //isAdmin == user.isAdmin &&
                   //isBlack == user.isBlack &&
                   Uid == user.Uid &&
                   Username == user.Username &&
                   Phone == user.Phone &&
                   Sex == user.Sex &&
                   Email == user.Email &&
                   Major == user.Major &&
                   Password == user.Password &&
                   IsAdmin == user.IsAdmin &&
                   IsBlack == user.IsBlack;
        }

        public override string ToString()
        {
            return uid + " " + username + " " + phone + " " + sex + " " + email + " " + major + " " + password + " " + isAdmin + " " + isBlack;
        }
    }

    public class Book
    {
        private String bid;
        private String bookname;
        private String author;
        private int leftnum;
        private Decimal price;
        private String bType;

        public Book()
        {
        }

        public Book(string bid, string bookname, string author, int leftnum, decimal price, string bType)
        {
            this.bid = bid;
            this.bookname = bookname;
            this.author = author;
            this.leftnum = leftnum;
            this.price = price;
            this.bType = bType;
        }

        public string Bid { get => bid; set => bid = value; }
        public string Bookname { get => bookname; set => bookname = value; }
        public string Author { get => author; set => author = value; }
        public int Leftnum { get => leftnum; set => leftnum = value; }
        public decimal Price { get => price; set => price = value; }
        public string BType { get => bType; set => bType = value; }

        public static Book ToBean(SqlDataReader reader)
        {
            Book book = null;
            if (reader.Read())
            {
                book = new Book(reader["bid"].ToString(), reader["bookname"].ToString(), reader["author"].ToString(),
                    Convert.ToInt32(reader["leftnum"].ToString()), Convert.ToDecimal(reader["price"]), reader["bTYpe"].ToString());

            }
            return book;
        }

        public static List<Book> ToBeanList(SqlDataReader reader)
        {
            Book book = null;
            List<Book> list = new List<Book>();
            while (reader.Read())
            {
                book = new Book(reader["bid"].ToString(), reader["bookname"].ToString(), reader["author"].ToString(),
                    Convert.ToInt32(reader["leftnum"].ToString()), Convert.ToDecimal(reader["price"]), reader["bTYpe"].ToString());
                list.Add(book);
            }
            return list;
        }

        public override bool Equals(object obj)
        {
            var book = obj as Book;
            return book != null &&
                   Bid == book.Bid &&
                   Bookname == book.Bookname &&
                   Author == book.Author &&
                   Leftnum == book.Leftnum &&
                   Price == book.Price &&
                   BType == book.BType;
        }
    }

    public class LogSheet
    {
        private String uid;
        private String username;
        private String bid;
        private String bookname;
        private DateTime borrowTime;
        private DateTime returnTime;
        private Boolean isReturn;

        public LogSheet()
        {
        }

        public LogSheet(string uid, string username, string bid, string bookname, DateTime borrowTime, DateTime returnTime, bool isReturn)
        {
            this.uid = uid;
            this.username = username;
            this.Bid = bid;
            this.bookname = bookname;
            this.borrowTime = borrowTime;
            this.returnTime = returnTime;
            this.isReturn = isReturn;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Username { get => username; set => username = value; }
        public string Bookname { get => bookname; set => bookname = value; }
        public DateTime BorrowTime { get => borrowTime; set => borrowTime = value; }
        public DateTime ReturnTime { get => returnTime; set => returnTime = value; }
        public bool IsReturn { get => isReturn; set => isReturn = value; }
        public string Bid { get => bid; set => bid = value; }

        public static List<LogSheet> toBeanList(SqlDataReader reader)
        {
            LogSheet logSheet = null;
            List<LogSheet> list = new List<LogSheet>();
            while (reader.Read())
            {
                logSheet = new LogSheet(reader["uid"].ToString(), reader["username"].ToString(),reader["bid"].ToString(), reader["bookname"].ToString(),
                    Convert.ToDateTime(reader["borrowTime"].ToString()), Convert.ToDateTime(reader["returnTime"].ToString()),
                    Convert.ToBoolean(reader["isReturn"])) ;
                list.Add(logSheet);
            }
            return list;
        }
    }

    public class LossList
    {
        private String uid;
        private String username;
        private String bookname;
        private DateTime lossDate;
        private Boolean isDeal;

        public LossList()
        {
        }

        public LossList(string uid, string username, string bookname, DateTime lossDate, bool isDeal)
        {
            this.Uid = uid;
            this.Username = username;
            this.Bookname = bookname;
            this.LossDate = lossDate;
            this.IsDeal = isDeal;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Username { get => username; set => username = value; }
        public string Bookname { get => bookname; set => bookname = value; }
        public DateTime LossDate { get => lossDate; set => lossDate = value; }
        public bool IsDeal { get => isDeal; set => isDeal = value; }

        public static List<LossList> toBeanList(SqlDataReader reader)
        {
            LossList lossList = null;
            List<LossList> list = new List<LossList>();
            while (reader.Read())
            {
                lossList = new LossList(reader["uid"].ToString(), reader["username"].ToString(), reader["bookname"].ToString(),
                    Convert.ToDateTime(reader["lossDate"]), Convert.ToBoolean(reader["isDeal"]));
                list.Add(lossList);
            }
            return list;
        }
    }
}
