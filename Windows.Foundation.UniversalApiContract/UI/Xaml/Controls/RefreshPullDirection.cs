// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RefreshPullDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the direction to pull a RefreshContainer to initiate a refresh.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum RefreshPullDirection
  {
    /// <summary>Pull from left to right to initiate a refresh.</summary>
    LeftToRight,
    /// <summary>Pull from top to bottom to initiate a refresh.</summary>
    TopToBottom,
    /// <summary>Pull from right to left to initiate a refresh.</summary>
    RightToLeft,
    /// <summary>Pull from bottom to top to initiate a refresh.</summary>
    BottomToTop,
  }
}
