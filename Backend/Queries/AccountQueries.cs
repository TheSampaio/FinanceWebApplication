namespace Backend.Queries
{
    public static class AccountQueries
    {
        public static string GetAll => "SELECT * FROM Accounts;";
        public static string GetById => "SELECT * FROM Accounts WHERE Id = @Id;";
    }
}