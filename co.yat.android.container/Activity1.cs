using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace co.yat.android.container
{
	[Activity (Label = "co.yat.android.container", MainLauncher = true)]
	public class Activity1 : CO.Yat.Android.Exampleview.MainActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			GetMessage("test","test");

		}

		public override void SendMessage (String uri, String json)
		{

			Console.WriteLine("Got Message " + uri);

			switch (uri) {
			case "/ExampleViewController/Button/{Click}":
				base.GetMessage("/ExampleViewController/View2/{Show}","{}");
				break;
			case "/View2/CloseButton/{Click}":
				GetMessage("/ExampleViewController/View2/{Hide}","{}");
				break;
			}


		}

	}
}


