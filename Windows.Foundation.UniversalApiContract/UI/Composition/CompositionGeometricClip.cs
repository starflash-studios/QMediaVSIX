// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGeometricClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Clips a portion of a visual. The visible portion of the visual is a shape defined by a CompositionGeometry. The portion of the visual outside the geometry is clipped.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionGeometricClip : CompositionClip, ICompositionGeometricClip
  {
    /// <summary>Gets or sets CompositionGeometry that defines the shape of the clip.</summary>
    /// <returns>A CompositionGeometry that defines the shape of the clip. The default is **null**.</returns>
    public extern CompositionGeometry Geometry { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a CompositionViewBox that maps the shape visual tree coordinates onto the visual.</summary>
    /// <returns>A CompositionViewBox that maps the shape visual tree coordinates onto the visual.</returns>
    public extern CompositionViewBox ViewBox { [MethodImpl] get; [MethodImpl] set; }
  }
}
