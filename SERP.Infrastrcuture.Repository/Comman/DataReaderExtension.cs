using System.Data.SqlClient;

namespace SERP.Infrastrcuture.Repository.Comman
{
    public static class DataReaderExtension
    {
        public static T DefaultIfNull<T>(this SqlDataReader reader, string columnName)
        {
            int colIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(colIndex))
            {
                return (T)reader[reader.GetName(colIndex)];
            }

            return default;
        }
    }
}
