//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace co.yat.ios.binding {
	[Register("CentralAccess", true)]
	public unsafe partial class CentralAccess : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selGetInstance = Selector.GetHandle ("GetInstance");
		[CompilerGenerated]
		static readonly IntPtr selLoadMainWindow = Selector.GetHandle ("LoadMainWindow");
		[CompilerGenerated]
		static readonly IntPtr selGetMessageJson_ = Selector.GetHandle ("GetMessage:json:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CentralAccess");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  CentralAccess () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CentralAccess (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public CentralAccess (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public CentralAccess (IntPtr handle) : base (handle) {}

		[Export ("GetInstance")]
		[CompilerGenerated]
		public static CentralAccess GetInstance ()
		{
			return (CentralAccess) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetInstance));
		}
		
		[Export ("LoadMainWindow")]
		[CompilerGenerated]
		public virtual void LoadMainWindow ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLoadMainWindow);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLoadMainWindow);
			}
		}
		
		[Export ("GetMessage:json:")]
		[CompilerGenerated]
		public virtual void GetMessage (NSString uri, NSString json)
		{
			if (uri == null)
				throw new ArgumentNullException ("uri");
			if (json == null)
				throw new ArgumentNullException ("json");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetMessageJson_, uri.Handle, json.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selGetMessageJson_, uri.Handle, json.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public new virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public new MonoLink Delegate {
			get {
				return WeakDelegate as MonoLink;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_MonoLink EnsureMonoLink ()
		{
			var del = Delegate;
			if (del == null || (!(del is _MonoLink))){
				del = new _MonoLink ();
				Delegate = del;
			}
			return (_MonoLink) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _MonoLink : co.yat.ios.binding.MonoLink { 
			public _MonoLink () {}
			
			internal EventHandler<LinkEventArgs> sendMessage;
			[Preserve (Conditional = true)]
			public override void SendMessage (NSObject sender, NSString uri, NSString json)
			{
				EventHandler<LinkEventArgs> handler = sendMessage;
				if (handler != null){
					var args = new LinkEventArgs (uri, json);
					handler (sender, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<LinkEventArgs> SendMessage {
			add { EnsureMonoLink ().sendMessage += value; }
			remove { EnsureMonoLink ().sendMessage -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CentralAccess */
	
	
	//
	// EventArgs classes
	//
	public partial class LinkEventArgs : EventArgs {
		public LinkEventArgs (NSString uri, NSString json)
		{
			this.Uri = uri;
			this.Json = json;
		}
		public NSString Uri { get; set; }
		public NSString Json { get; set; }
	}
	
}
