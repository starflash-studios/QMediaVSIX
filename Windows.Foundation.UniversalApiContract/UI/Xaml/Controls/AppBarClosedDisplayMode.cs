// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBarClosedDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify whether icon buttons are displayed when an app bar is not completely open.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppBarClosedDisplayMode
  {
    /// <summary>Icon buttons are displayed but labels are not visible.</summary>
    Compact,
    /// <summary>Only the ellipsis is displayed. Neither icon buttons nor labels are visible.</summary>
    Minimal,
    /// <summary>The app bar is not displayed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Hidden,
  }
}
