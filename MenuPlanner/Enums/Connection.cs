namespace MenuPlanner.Enums
{
    public enum Connection
    {
        DefaultDb,
        TestDb
        // Her kan du legge til andre databaser, f.eks. Azure SQL, MySql, ...
        // Husk da også å legge til selve connection-stringen i appsettings.json,
        // med samme navn som enum-verdien du oppretter her.
    }
}
