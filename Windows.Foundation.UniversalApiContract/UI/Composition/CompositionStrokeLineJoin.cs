// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionStrokeLineJoin
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines constants that specify the shape used to join two lines or segments.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum CompositionStrokeLineJoin
  {
    /// <summary>Line joins use regular angular vertices.</summary>
    Miter,
    /// <summary>Line joins use beveled vertices.</summary>
    Bevel,
    /// <summary>Line joins use rounded vertices.</summary>
    Round,
    /// <summary>Line joins use regular angular vertices unless the join would extend beyond the miter limit; otherwise, line joins use beveled vertices.</summary>
    MiterOrBevel,
  }
}
