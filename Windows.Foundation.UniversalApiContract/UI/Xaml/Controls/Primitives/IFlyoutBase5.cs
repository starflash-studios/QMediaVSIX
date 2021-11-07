// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(2906570951, 4795, 23155, 183, 142, 16, 81, 146, 202, 115, 214)]
  [ExclusiveTo(typeof (FlyoutBase))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IFlyoutBase5
  {
    FlyoutShowMode ShowMode { get; set; }

    bool InputDevicePrefersPrimaryCommands { get; }

    bool AreOpenCloseAnimationsEnabled { get; set; }

    bool IsOpen { get; }

    void ShowAt(DependencyObject placementTarget, FlyoutShowOptions showOptions);
  }
}
