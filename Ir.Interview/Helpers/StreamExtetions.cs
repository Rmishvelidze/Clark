using Ir.Interview.Models;

namespace Ir.Interview.Helpers
{
    public static class StreamExtetions
    {
        public static void WriteInFile(this List<ProductForCsv> productForCsvs, string filePath)
        {
            try
            {
                foreach (var item in productForCsvs)
                {
                    using var file = new StreamWriter(@filePath, true);
                    file.WriteLine(item.Id + "," + item.Name + "," + item.Barnd + "," + item.Inventory);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
