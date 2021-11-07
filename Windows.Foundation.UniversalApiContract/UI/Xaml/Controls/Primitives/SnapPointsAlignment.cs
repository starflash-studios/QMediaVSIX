// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SnapPointsAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify options for snap point alignment relative to an edge. Which edge depends on the orientation of the object where the alignment is applied.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SnapPointsAlignment
  {
    /// <summary>Use snap points grouped closer to the orientation edge.</summary>
    Near,
    /// <summary>Use snap points that are centered in the orientation.</summary>
    Center,
    /// <summary>Use snap points grouped farther from the orientation edge.</summary>
    Far,
  }
}
