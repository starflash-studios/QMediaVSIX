// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarButtonFlyoutPlacement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies the location of the ink stroke configuration flyout relative to the InkToolbar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum InkToolbarButtonFlyoutPlacement
  {
    /// <summary>The system determines which edge of the ink toolbar to align the flyout.</summary>
    Auto,
    /// <summary>Flyout is aligned to the top edge of the ink toolbar.</summary>
    Top,
    /// <summary>Flyout is aligned to the bottom edge of the ink toolbar.</summary>
    Bottom,
    /// <summary>Flyout is aligned to the left edge of the ink toolbar.</summary>
    Left,
    /// <summary>Flyout is aligned to the right edge of the ink toolbar.</summary>
    Right,
  }
}
