// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Control))]
  [WebHostHidden]
  [Guid(1509795624, 49242, 20162, 138, 75, 6, 173, 105, 182, 110, 21)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IControlStatics4
  {
    DependencyProperty IsFocusEngagementEnabledProperty { get; }

    DependencyProperty IsFocusEngagedProperty { get; }

    DependencyProperty RequiresPointerProperty { get; }

    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }

    DependencyProperty ElementSoundModeProperty { get; }
  }
}
