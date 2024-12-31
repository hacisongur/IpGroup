
namespace ProgrammersBlog.Services.Utilities
{
    public static class Messages
    {
        // Messages.Category.NotFound()
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir İp bulunamadı.";
                return "Böyle bir İp bulunamadı.";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı İp başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı İp başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı İp başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı İp başarıyla veritabanından silinmiştir.";
            }
        }

    }
}
