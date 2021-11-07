// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.HorizontalAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Indicates where an element should be displayed on the horizontal axis relative to the allocated layout slot of the parent element.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HorizontalAlignment
  {
    /// <summary>An element aligned to the left of the layout slot for the parent element.</summary>
    Left,
    /// <summary>An element aligned to the center of the layout slot for the parent element.</summary>
    Center,
    /// <summary>An element aligned to the right of the layout slot for the parent element.</summary>
    Right,
    /// <summary>An element stretched to fill the entire layout slot of the parent element.</summary>
    Stretch,
  }
}
