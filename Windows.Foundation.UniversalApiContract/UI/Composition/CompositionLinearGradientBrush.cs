// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionLinearGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a brush that paints an area with a linear gradient.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class CompositionLinearGradientBrush : 
    CompositionGradientBrush,
    ICompositionLinearGradientBrush
  {
    /// <summary>Gets or sets the ending two-dimensional coordinates of the linear gradient.</summary>
    /// <returns>The ending two-dimensional coordinates of the linear gradient.</returns>
    public extern Vector2 EndPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the starting two-dimensional coordinates of the linear gradient.</summary>
    /// <returns>The starting two-dimensional coordinates for the linear gradient.</returns>
    public extern Vector2 StartPoint { [MethodImpl] get; [MethodImpl] set; }
  }
}
