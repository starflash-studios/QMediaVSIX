// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionStrokeDashArray
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
  /// <summary>Represents a collection of values that indicates the pattern of dashes and gaps that is used to outline shapes.</summary>
  [DualApiPartition(version = 167772165)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionStrokeDashArray : 
    CompositionObject,
    IVector<float>,
    IIterable<float>
  {
    [MethodImpl]
    public extern float GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<float> GetView();

    [MethodImpl]
    public extern bool IndexOf(float value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, float value);

    [MethodImpl]
    public extern void InsertAt(uint index, float value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(float value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] float[] items);

    [MethodImpl]
    public extern void ReplaceAll(float[] items);

    [MethodImpl]
    public extern IIterator<float> First();
  }
}
