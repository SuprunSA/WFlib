namespace Students.BL.Configuration
{
    public class ConnectionStringConfig
    {
        public string ConnectionString { get; set; }

        public ConnectionStringConfig()
        {
            ConnectionString = string.Format("Server=DESKTOP-VH49AOP;Database=Students;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;encrypt=false");
        }
    }
}
