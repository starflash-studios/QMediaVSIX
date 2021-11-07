// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEllipseGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents an ellipse with the specified center and radius.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionEllipseGeometry : CompositionGeometry, ICompositionEllipseGeometry
  {
    /// <summary>Gets or sets the center point of the ellipse.</summary>
    /// <returns>The center point of the ellipse.</returns>
    public extern Vector2 Center { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius of the ellipse.</summary>
    /// <returns>The radius of the ellipse.</returns>
    public extern Vector2 Radius { [MethodImpl] get; [MethodImpl] set; }
  }
}
