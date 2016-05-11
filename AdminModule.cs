using System;
using System.Collections.Generic;
using System.Text;


public class AdministratorModule
{
    private class Admin
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int ID { get; set; }

        public const int privilage = 3;

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

    }


}
