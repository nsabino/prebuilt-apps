// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace FieldService.iOS
{
	[Register ("AddItemController")]
	partial class AddItemController
	{
		[Outlet]
		UIKit.UIBarButtonItem cancel { get; set; }

		[Outlet]
		UIKit.UIToolbar toolbar { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("Cancel:")]
		partial void Cancel (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (cancel != null) {
				cancel.Dispose ();
				cancel = null;
			}

			if (toolbar != null) {
				toolbar.Dispose ();
				toolbar = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
