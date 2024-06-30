using System.Text.Json;
namespace HW_15_28_06_2024
{
//    Реалізувати додаток, який запитує IP адрес, робить http запит до https://ipwhois.io/documentation
//та виводить місто, де зареєстровано даний ip.Результати запитів зберігаємо у файл ip_date.json
    internal class Program
    {
        static void Main(string[] args)
        {
            IPInfoData iPInfoData = new IPInfoData();
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine("Enter IP (ex 1.1.1.1)");
                iPInfoData.GetDataFromServer(Console.ReadLine());
                count--;
            };
            Thread.Sleep(1000);
            iPInfoData.Save();
            iPInfoData.Print();
        }
    }
}
