

namespace Users_Crud.Models
{
    using System;



    public class Users_Crud
    {
        public partial class Users_Crud
        {
            public int Id { get; set; }
            public string Name { get; set; }    
            public string Email { get; set; }
            public string Password { get; set; }    
            public string Username { get; set; } = null;
            public string UserEmail { get; set; }   
            public string PasswordEmail { get; set; }   
                    
        }
    }

}


