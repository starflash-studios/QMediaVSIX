// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionLineGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a straight line between two points.</summary>
  [DualApiPartition(version = 167772165)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionLineGeometry : CompositionGeometry, ICompositionLineGeometry
  {
    /// <summary>Gets or sets the starting point of the line.</summary>
    /// <returns>The starting point of the line.</returns>
    public extern Vector2 Start { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end point of the line.</summary>
    /// <returns>The end point of the line.</returns>
    public extern Vector2 End { [MethodImpl] get; [MethodImpl] set; }
  }
}
