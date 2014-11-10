
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace menubar
{
	public partial class OpenSiteController : MonoMac.AppKit.NSWindowController
	{
		public OpenSiteController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		[Export ("initWithCoder:")]
		public OpenSiteController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}

		public string Url {
			get;
			set;
		}

		public NSCellStateValue IOS {
			get;
			set;
		}

		public OpenSiteController () : base ("OpenSite")
		{
			Initialize ();
		}

		void Initialize ()
		{
		}

		public EventHandler Done {
			get;
			set;
		}

		public override void WindowDidLoad ()
		{
			base.WindowDidLoad ();
			Window.Center ();

			okButton.Activated += (object sender, EventArgs e) => {

				Url=urlField.StringValue; 
				if(!String.IsNullOrEmpty(Url) && !Url.ToLowerInvariant().StartsWith("http"))
					Url = "http://" +Url;

				IOS=iosButton.State;

				Done(this,null);
				Close();
			};
		}

		public new OpenSite Window {
			get {
				return (OpenSite)base.Window;
			}
		}
	}
}

