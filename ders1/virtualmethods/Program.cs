namespace virtualmethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            sqlServer.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        //virtual metodlar, alt sınıflarda override edilebilir. SqlServer ve MySql Add() şekilleri farklıdır.
        //Aynı isimli farklı fonksiyolar ile çağırılmalıdır.
        public virtual void Add()
        {
            Console.WriteLine("Database'e veri eklendi.");
        }
        //Silme işlemi her veritabanında farklı olabilir.
        //Bu yüzden abstract olarak tanımlanmıştır.
        //Add()'de de öyle ama öğrenmek için burada öyle gösterdik.
        public abstract void Delete();
 
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("SqlServer'e veri eklendi.");
            base.Add();
        }
        public override void Delete()
        {
            Console.WriteLine("SqlServer'den veri silindi.");
        }
    }

    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("MySql'e veri eklendi.");
        }
        public override void Delete()
        {
            Console.WriteLine("MySql'den veri silindi.");
        }
    }
}