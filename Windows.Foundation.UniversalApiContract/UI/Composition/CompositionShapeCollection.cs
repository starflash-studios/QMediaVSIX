// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionShapeCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a collection of CompositionShape objects that can be individually accessed by index.</summary>
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CompositionShapeCollection : 
    CompositionObject,
    IVector<CompositionShape>,
    IIterable<CompositionShape>
  {
    [MethodImpl]
    public extern CompositionShape GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<CompositionShape> GetView();

    [MethodImpl]
    public extern bool IndexOf(CompositionShape value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, CompositionShape value);

    [MethodImpl]
    public extern void InsertAt(uint index, CompositionShape value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(CompositionShape value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] CompositionShape[] items);

    [MethodImpl]
    public extern void ReplaceAll(CompositionShape[] items);

    [MethodImpl]
    public extern IIterator<CompositionShape> First();
  }
}
