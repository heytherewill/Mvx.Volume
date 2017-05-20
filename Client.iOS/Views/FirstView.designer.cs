// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Client.iOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Mute { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider Percentage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Mute != null) {
                Mute.Dispose ();
                Mute = null;
            }

            if (Percentage != null) {
                Percentage.Dispose ();
                Percentage = null;
            }
        }
    }
}