namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo(){Name="Mustafa", Phone="532", Email = "mustafa@kotan.com",WillAttend=true});
            _users.Add(new UserInfo(){Name="Selim", Phone="533", Email = "selim@kotan.com",WillAttend=true});
            _users.Add(new UserInfo(){Name="Vefa", Phone="543", Email = "vefa@kotan.com",WillAttend=false});
            _users.Add(new UserInfo(){Name="Kurban", Phone="543", Email = "kurban@kotan.com",WillAttend=true});
        }



        public static List<UserInfo> Users
        {
            get {return _users;}
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }

    }
}