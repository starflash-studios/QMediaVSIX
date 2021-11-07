// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VerticalAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes how a child element is vertically positioned or stretched within a parent's layout slot.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum VerticalAlignment
  {
    /// <summary>The element is aligned to the top of the parent's layout slot.</summary>
    Top,
    /// <summary>The element is aligned to the center of the parent's layout slot.</summary>
    Center,
    /// <summary>The element is aligned to the bottom of the parent's layout slot.</summary>
    Bottom,
    /// <summary>The element is stretched to fill the entire layout slot of the parent element.</summary>
    Stretch,
  }
}
