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
	[Register ("OpenSiteController")]
	partial class OpenSiteController
	{
		[Outlet]
		MonoMac.AppKit.NSButton iosButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton okButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField urlField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (iosButton != null) {
				iosButton.Dispose ();
				iosButton = null;
			}

			if (okButton != null) {
				okButton.Dispose ();
				okButton = null;
			}

			if (urlField != null) {
				urlField.Dispose ();
				urlField = null;
			}
		}
	}

	[Register ("OpenSite")]
	partial class OpenSite
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
