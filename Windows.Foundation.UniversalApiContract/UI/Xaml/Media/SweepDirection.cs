// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.SweepDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Specifies the direction in which an elliptical arc is drawn.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SweepDirection
  {
    /// <summary>Arcs are drawn in a counterclockwise (negative-angle) direction.</summary>
    Counterclockwise,
    /// <summary>Arcs are drawn in a clockwise (positive-angle) direction.</summary>
    Clockwise,
  }
}
