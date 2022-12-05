using Exception.Controller;
using ServiceLayer.Services;

//LibraryService library = new();

//library.Libraries();

//LibraryController controller = new();
//Console.Write("Please enter library id:  ");
//int id = Convert.ToInt32(Console.ReadLine());
//controller.GetAllBooks(id);

//bool isParse = true;

//try
//{
//	//string name = null;
//	//Console.WriteLine(name.ToString());

//	int index = int.Parse(Console.ReadLine());

//	int[] arr = new int[2];
//	arr[0] = 1;

//	string name = null;

//	if(name is null)
//	{
//		throw new IndexOutOfRangeException();
//	}

//	isParse = true;

//	Console.WriteLine(arr[0]);
//}
//catch (System.Exception ex)
//{
//	Console.WriteLine(ex.Message);
//	isParse = false;
//}
//finally
//{
//	if (isParse)
//	{
//		Console.WriteLine("Welcome");
//	}
//	else
//	{
//		Console.WriteLine("Failed");
//	}
//}

//GetnameById(null);
//static void GetnameById(int? id)
//{
//	try
//	{
//		if(id == null)
//		{
//			throw new ArgumentNullException();
//		}

//		Console.WriteLine("Name id: "+id);
//	}
//	catch (System.Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}
//}

//AccountController account = new AccountController();
//account.Register();

AccountController account = new AccountController();
account.GetUserById();

