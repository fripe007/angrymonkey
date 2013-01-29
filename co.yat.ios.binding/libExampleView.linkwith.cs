using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libExampleView.a", LinkTarget.Simulator, ForceLoad = true)]