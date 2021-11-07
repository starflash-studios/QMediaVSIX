// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickerFlyoutPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the visual container for the TimePickerFlyout.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITimePickerFlyoutPresenterStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimePickerFlyoutPresenter : 
    Control,
    ITimePickerFlyoutPresenter,
    ITimePickerFlyoutPresenter2
  {
    /// <summary>Gets or sets a value that indicates whether the default shadow effect is shown.</summary>
    /// <returns>**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsDefaultShadowEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsDefaultShadowEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDefaultShadowEnabled dependency property.</returns>
    public static extern DependencyProperty IsDefaultShadowEnabledProperty { [MethodImpl] get; }
  }
}
