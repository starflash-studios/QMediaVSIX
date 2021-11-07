// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionProjectedShadowCaster
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents an object that casts a projected shadow.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class CompositionProjectedShadowCaster : 
    CompositionObject,
    ICompositionProjectedShadowCaster
  {
    /// <summary>Gets or sets the brush used to draw the shadow.</summary>
    /// <returns>The brush used to draw the shadow.</returns>
    public extern CompositionBrush Brush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Visual that casts the shadow.</summary>
    /// <returns>The Visual that casts the shadow.</returns>
    public extern Visual CastingVisual { [MethodImpl] get; [MethodImpl] set; }
  }
}
