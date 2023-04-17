namespace Users.Controllers
{
    public class Users_Crud : Controllers
    {
        public Users_Crud()
        {
            private DB_UsersCrudEntity db = new DB_UsersCrudEntity();
            
            public actionResult Index ()
            {
               return view .Index (db user);
            }
            
        }
    }
}