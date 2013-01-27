using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using co.yat.ios.binding;

namespace co.yat.ios.container
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{

		private CentralAccess _access;

		// class-level declarations
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			System.Console.WriteLine("Initialising Central Access");

			_access = CentralAccess.GetInstance();

			//wire up the message delegate
			_access.SendMessage += (s,e) => {

				Console.WriteLine("Message back " + ((LinkEventArgs)e).Uri + " " + ((LinkEventArgs)e).Json);

				switch(((LinkEventArgs)e).Uri) {
					case "/ExampleViewController/Button/{Click}":
					_access.GetMessage(new NSString("/ExampleViewController/SecondViewController/{Show}"),new NSString("{}"));
						break;
					case "/SecondViewController/Button/{Click}":
					_access.GetMessage(new NSString("/ExampleViewController/SecondViewController/{Hide}"),new NSString("{}"));
						break;
				}

			};

			_access.LoadMainWindow();
			
			return true;
		}
	}

}

