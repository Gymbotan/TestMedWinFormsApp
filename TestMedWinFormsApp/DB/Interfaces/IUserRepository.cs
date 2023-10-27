namespace TestMedWinFormsApp.DB.Interfaces
{
    public interface IUsersRepository
    {
        void AddUser(string login, string password);
        bool IsLoginExist(string login);
        bool IsUserExist(string login, string password);
    }
}
