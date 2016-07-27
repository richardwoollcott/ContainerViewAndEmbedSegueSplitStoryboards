// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ContainerViewAndEmbedSegue
{
    [Register ("HomePageViewController")]
    partial class HomePageViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FirstPageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SecondPageButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FirstPageButton != null) {
                FirstPageButton.Dispose ();
                FirstPageButton = null;
            }

            if (SecondPageButton != null) {
                SecondPageButton.Dispose ();
                SecondPageButton = null;
            }
        }
    }
}