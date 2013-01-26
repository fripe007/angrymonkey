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

			CentralAccess access = new CentralAccess();
			//wire up the message delegate
			access.SendMessage += (s,e) => {
				Console.WriteLine("Message back " + ((LinkEventArgs)e).Uri + " " + ((LinkEventArgs)e).Json);
			};

			access.GetMessage(new NSString("/pies/cakes"),new NSString("{}"));
			
			return true;
		}
	}

}

