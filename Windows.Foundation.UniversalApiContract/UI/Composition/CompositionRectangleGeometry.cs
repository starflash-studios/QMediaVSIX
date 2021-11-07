// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionRectangleGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a rectangle shape of the specified size.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionRectangleGeometry : 
    CompositionGeometry,
    ICompositionRectangleGeometry
  {
    /// <summary>Gets or sets the offset of the rectangle.</summary>
    /// <returns>The offset of the rectangle.</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height and width of the rectangle.</summary>
    /// <returns>The height and width of the rectangle.</returns>
    public extern Vector2 Size { [MethodImpl] get; [MethodImpl] set; }
  }
}
