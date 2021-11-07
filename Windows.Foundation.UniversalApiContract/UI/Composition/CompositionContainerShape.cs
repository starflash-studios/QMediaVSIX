// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionContainerShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a container for CompositionShapes, used to group items that share 2D transforms.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class CompositionContainerShape : CompositionShape, ICompositionContainerShape
  {
    /// <summary>Gets the collection of CompostionShapes in this container.</summary>
    /// <returns>The collection of CompostionShapes in this container.</returns>
    public extern CompositionShapeCollection Shapes { [MethodImpl] get; }
  }
}
