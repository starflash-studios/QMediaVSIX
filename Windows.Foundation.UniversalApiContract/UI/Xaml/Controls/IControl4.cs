// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(236498670, 24366, 17642, 133, 19, 211, 135, 92, 10, 117, 19)]
  [ExclusiveTo(typeof (Control))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IControl4
  {
    bool IsFocusEngagementEnabled { get; set; }

    bool IsFocusEngaged { get; set; }

    RequiresPointer RequiresPointer { get; set; }

    DependencyObject XYFocusLeft { get; set; }

    DependencyObject XYFocusRight { get; set; }

    DependencyObject XYFocusUp { get; set; }

    DependencyObject XYFocusDown { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }

    event TypedEventHandler<Control, FocusEngagedEventArgs> FocusEngaged;

    event TypedEventHandler<Control, FocusDisengagedEventArgs> FocusDisengaged;

    void RemoveFocusEngagement();
  }
}
