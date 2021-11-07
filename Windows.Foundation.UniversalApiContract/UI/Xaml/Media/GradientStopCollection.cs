// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientStopCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a collection of GradientStop objects that can be individually accessed by index.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GradientStopCollection : IVector<GradientStop>, IIterable<GradientStop>
  {
    /// <summary>Initializes a new instance of the GradientStopCollection class.</summary>
    [MethodImpl]
    public extern GradientStopCollection();

    [MethodImpl]
    public extern GradientStop GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<GradientStop> GetView();

    [MethodImpl]
    public extern bool IndexOf(GradientStop value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, GradientStop value);

    [MethodImpl]
    public extern void InsertAt(uint index, GradientStop value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(GradientStop value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] GradientStop[] items);

    [MethodImpl]
    public extern void ReplaceAll(GradientStop[] items);

    [MethodImpl]
    public extern IIterator<GradientStop> First();
  }
}
