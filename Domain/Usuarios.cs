using System;
using DataAccess;
namespace Domain
{
    public class Usuarios
    {
        int UserId;
        string LoginName, Password, FirstName, LastName, Email;

        public string LoginName1 { get => LoginName; set => LoginName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }        
        public string Email1 { get => Email; set => Email = value; }
        public int UserId1 { get => UserId; set => UserId = value; }
    }
}
