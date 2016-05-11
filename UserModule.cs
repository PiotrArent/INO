
public class UserModule
{
    private class User
    {
        public string accountname { get; set; }
        public string fname { get; set; }
        public string sname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int privilage { get; set; }
        public int ID { get; set; }


        private List<record> history;

        List<record> historyGet()
        {
            return history;
        }
        void historyModify(List<record> history)
        {
            this.history = history;
        }
        void historyAdd(record temp)
        {
            this.history.Add(temp);
        }

        public User GetUserInformation()
        {
            return this;
        }

    }
    public class record
    {
        public DateTime date { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public int ID { get; set; }

        record get()
        {
            return this;
        }
        protected void set(DateTime date, string title, int type, string content, int ID)
        {
            this.date = date;
            this.title = title;
            this.type = type;
            this.content = content;
            this.ID = ID;
        }
    }

    public class API
    {
        public User GetUserByID(int ID) { }
        public bool LogingIn(String accountname, String password) { }
        public bool CheckUserPrivlage(int ID, int RequiredPrivlage) { } 
    }


}
