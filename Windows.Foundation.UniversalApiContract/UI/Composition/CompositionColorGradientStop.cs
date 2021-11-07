// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionColorGradientStop
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Describes the location and color of a transition point in a gradient.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public sealed class CompositionColorGradientStop : CompositionObject, ICompositionColorGradientStop
  {
    /// <summary>Gets or sets the color of the gradient stop.</summary>
    /// <returns>The color of the gradient stop. The default is Transparent.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the location of the gradient stop within the gradient vector.</summary>
    /// <returns>The relative location of this gradient stop along the gradient vector. The default is 0.</returns>
    public extern float Offset { [MethodImpl] get; [MethodImpl] set; }
  }
}
