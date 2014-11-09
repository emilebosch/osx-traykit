// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace menubar
{
	[Register ("AppDelegate")]
	partial class AppDelegate
	{
		[Outlet]
		MonoMac.WebKit.WebView webview { get; set; }

		[Outlet]
		MonoMac.WebKit.WebView webview2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSWindow window { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (webview2 != null) {
				webview2.Dispose ();
				webview2 = null;
			}

			if (webview != null) {
				webview.Dispose ();
				webview = null;
			}

			if (window != null) {
				window.Dispose ();
				window = null;
			}
		}
	}
}
