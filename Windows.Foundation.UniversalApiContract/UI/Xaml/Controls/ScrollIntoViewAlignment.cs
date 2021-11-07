// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollIntoViewAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that describe how an item that is programmatically scrolled into view aligns with the visible area.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ScrollIntoViewAlignment
  {
    /// <summary>The item aligns with the nearest edge.</summary>
    Default,
    /// <summary>The item aligns with the leading edge.</summary>
    Leading,
  }
}
