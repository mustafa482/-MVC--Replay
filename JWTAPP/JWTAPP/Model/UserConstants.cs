namespace JWTAPP.Model
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel(){Username="Mustafa",EmailAddress="mustafa.mustafayev@gmail.com",Password="Mustafa_Password",
            GivenName="Musti",Surname="Mustafayev",Role="Backend Devop"},

            new UserModel(){Username="Ilkin",EmailAddress="ilkin.nesibli@gmail.com",Password="Ilkin_Password",
            GivenName="Ilko",Surname="Nesibli",Role="Frontend Devop"}

        };

    }
}
