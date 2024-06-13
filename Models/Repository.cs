namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo(){Id=1, Name="Mustafa", Phone="532", Email = "mustafa@kotan.com",WillAttend=true});
            _users.Add(new UserInfo(){Id=2, Name="Selim", Phone="533", Email = "selim@kotan.com",WillAttend=true});
            _users.Add(new UserInfo(){Id=3, Name="Vefa", Phone="543", Email = "vefa@kotan.com",WillAttend=false});
            _users.Add(new UserInfo(){Id=4, Name="Kurban", Phone="543", Email = "kurban@kotan.com",WillAttend=true});
        }



        public static List<UserInfo> Users
        {
            get {return _users;}
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count +1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user=>user.Id==id);
        }

    }
}