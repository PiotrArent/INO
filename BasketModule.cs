    class BasketModule
    {

        private class basket
        {
            List<product> productlist;

            List<product> productlistGet()
            {
                return productlist;
            }
            void commentariesModify(List<product> commentaries)
            {
                this.productlist = commentaries;
            }
            void commentariesAdd(product temp)
            {
                this.productlist.Add(temp);
            }



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




            private int userID { get; set; }
        }
        public class API
        {
            public void InitializeUserBasket(int userID) { }
            public basket GetUserBasketData(int userID){ }
            public void AddToUserBasket(int userID, product pro) { }
        }
    }

}
