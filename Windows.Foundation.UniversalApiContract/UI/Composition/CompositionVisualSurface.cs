// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionVisualSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a visual tree as an ICompositionSurface that can be used to paint a Visual using a CompositionBrush.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionVisualSurface : 
    CompositionObject,
    ICompositionVisualSurface,
    ICompositionSurface
  {
    /// <summary>Gets or sets the root of the visual tree that is the target of the visual surface.</summary>
    /// <returns>The root of the visual tree that is the target of the visual surface.</returns>
    public extern Visual SourceVisual { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the coordinates of the top-left corner of the part of the visual surface used for rendering.</summary>
    /// <returns>The coordinates of the top-left corner of the part of the visual surface used for rendering.</returns>
    public extern Vector2 SourceOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the the height and width of the part of the visual surface used for rendering.</summary>
    /// <returns>The height and width of the part of the visual surface used for rendering.</returns>
    public extern Vector2 SourceSize { [MethodImpl] get; [MethodImpl] set; }
  }
}
