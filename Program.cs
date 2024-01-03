internal class Program
{
    private static void Main(string[] args)
    {
        int deger;
        deger = 2;
        string degisken = null;
        string Degisken = null;
        string Program = "";


        byte b = 5;// 0-128 1 byte
        sbyte sb = 5;// -128 -127 1 byte
        short s = 5; //  2 byte
        ushort us = 5;//  2 byte

        Int16 i16 = 2;//  2 byte
        int i = 2;//  4 byte
        Int32 i32 = 2;//  4 byte
        Int64 i64 = 2;//  8 byte

        uint ui = 2;//  4 byte
        long l = 2;//  8 byte
        ulong ul = 2;//  8 byte

        float f = 2;//  4 byte
        double d = 2;//  8 byte
        decimal de = 5;//  16 byte

        char ch = '2'; // 2 byte
        string str = "erkan";

        bool blo = true;

        DateTime dt = DateTime.Now;

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.1;

        // string ifadeler

        string str1 = string.Empty;

        str1 = "Erkan Yüksel";

        string ad = "erkan";
        string soyad = "yuksel";

        string tamIsim = ad + " " + soyad;

        // int tanımlama sekiklleri

        int int1 = 5;
        int int2 = 3;
        int int3 = int1 * int2;


        // boolen 

        bool b12 = 10 > 2;

        // degisken donusumleri

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();

        // int donusumleri
        int int21 = int20 + Convert.ToInt32(str20);

        Console.WriteLine(yeniDeger);// çıktı 2020
        Console.WriteLine(int21);// çıktı 40

        int int22 = int20 + int.Parse(str20); // çıktı 40

        // datetime donusumleri

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);// çıktı 40


        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);// çıktı 40

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);// çıktı 40

    }
}