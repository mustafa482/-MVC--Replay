





MyClass nesne = new MyClass();

nesne[3] = 11;

Console.WriteLine(nesne[3]);


class MyClass
{
    int[] a = new int[5];
    public int this[int index]
    {
        get
        {
            return a[index];
        }
        set
        {
            a[index] = 3 * value + 1;
        }
    }
}

//using System.Data.SqlClient;

//SqlDataReader reader = new SqlCommand().ExecuteReader();

//string a;
//while (reader.Read())
//{
//    a = reader["sifre"].ToString();
//}