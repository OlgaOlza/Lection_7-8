// Просмотр информации про папки 

string path = "\Users\Ольза\Desktop\GeekBrain";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);