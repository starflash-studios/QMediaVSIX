// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionPath
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a series of connected lines and curves.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [Activatable(typeof (ICompositionPathFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionPath : ICompositionPath, IGeometrySource2D
  {
    /// <summary>Initializes a new instance of the CompositionPath class.</summary>
    /// <param name="source">The source of the path data.</param>
    [MethodImpl]
    public extern CompositionPath(IGeometrySource2D source);
  }
}
