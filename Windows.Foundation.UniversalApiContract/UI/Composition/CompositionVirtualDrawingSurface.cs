// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionVirtualDrawingSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  /// <summary>Represents sparsely allocated bitmaps that can be associated with visuals for composition in a visual tree.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Composable(typeof (ICompositionVirtualDrawingSurfaceFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class CompositionVirtualDrawingSurface : 
    CompositionDrawingSurface,
    ICompositionVirtualDrawingSurface
  {
    /// <summary>Clears portions of a virtual drawing surface that were previously defined. Areas that are cleared will be treated as empty once again, and video memory that was previously backing them will be reclaimed.</summary>
    /// <param name="rects">The region of the drawing surface to trim.</param>
    [MethodImpl]
    public extern void Trim(RectInt32[] rects);
  }
}
