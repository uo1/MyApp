using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MyApp;

[Display(Name = nameof(MyResource.MyString), ResourceType = typeof(MyResource))]
static class MyApp
{
	static void Main(string[] _)
	{
		// Throws this exception if MyResource is not public:
		// System.InvalidOperationException
		// Message = Cannot retrieve property 'Name' because localization failed.  Type 'MyApp.MyResource' is not public or does not contain a public static string property with the name 'MyString'.
		// StackTrace:
		//  at System.ComponentModel.DataAnnotations.LocalizableString.<>c__DisplayClass12_1.<GetLocalizableValue>b__2()
		//  at MyApp.MyApp.Main(String[] _) in D:\sources\MyApp\MyApp.cs:line 17
		Console.WriteLine(typeof(MyApp).GetCustomAttribute<DisplayAttribute>()!.GetName());
	}
}
