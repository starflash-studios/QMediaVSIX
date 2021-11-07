// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents the base class for composition geometries.</summary>
  [DualApiPartition(version = 167772165)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Composable(typeof (ICompositionGeometryFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class CompositionGeometry : CompositionObject, ICompositionGeometry
  {
    /// <summary>Gets or sets the amount to trim the end of the geometry path.</summary>
    /// <returns>The amount to trim the end of the geometry path. The default is 0.</returns>
    public extern float TrimEnd { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount to offset trimming the geometry path.</summary>
    /// <returns>The amount to offset trimming the geometry path. The default is 0.</returns>
    public extern float TrimOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount to trim the start of the geometry path.</summary>
    /// <returns>The amount to trim the start of the geometry path. The default is 0.</returns>
    public extern float TrimStart { [MethodImpl] get; [MethodImpl] set; }
  }
}
