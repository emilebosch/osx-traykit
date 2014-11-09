using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using Shortcut;

[assembly: MonoMac.RequiredFramework("MASShortcut.dylib")]
namespace menubar
{
	class MainClass	
	{
		static void Main (string[] args)
		{
			Type t = typeof(MASShortcut);
			MonoMac.ObjCRuntime.Runtime.RegisterAssembly(t.Assembly); 
	
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}

