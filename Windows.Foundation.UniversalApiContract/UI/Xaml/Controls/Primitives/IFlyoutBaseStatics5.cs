// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FlyoutBase))]
  [Guid(1777185372, 39210, 21547, 188, 255, 47, 127, 133, 85, 35, 189)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IFlyoutBaseStatics5
  {
    DependencyProperty TargetProperty { get; }

    DependencyProperty ShowModeProperty { get; }

    DependencyProperty InputDevicePrefersPrimaryCommandsProperty { get; }

    DependencyProperty AreOpenCloseAnimationsEnabledProperty { get; }

    DependencyProperty IsOpenProperty { get; }
  }
}
