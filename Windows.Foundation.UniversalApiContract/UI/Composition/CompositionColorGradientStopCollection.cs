// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionColorGradientStopCollection
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
  /// <summary>Represents a collection of CompositionColorGradientStop objects that can be individually accessed by index.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CompositionColorGradientStopCollection : 
    ICompositionColorGradientStopCollection,
    IIterable<CompositionColorGradientStop>,
    IVector<CompositionColorGradientStop>
  {
    [MethodImpl]
    public extern IIterator<CompositionColorGradientStop> First();

    [MethodImpl]
    public extern CompositionColorGradientStop GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<CompositionColorGradientStop> GetView();

    [MethodImpl]
    public extern bool IndexOf(CompositionColorGradientStop value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, CompositionColorGradientStop value);

    [MethodImpl]
    public extern void InsertAt(uint index, CompositionColorGradientStop value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(CompositionColorGradientStop value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] CompositionColorGradientStop[] items);

    [MethodImpl]
    public extern void ReplaceAll(CompositionColorGradientStop[] items);
  }
}
