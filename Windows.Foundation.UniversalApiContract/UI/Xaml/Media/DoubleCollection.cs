// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.DoubleCollection
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
  /// <summary>Represents an ordered collection of Double values.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DoubleCollection : IVector<double>, IIterable<double>
  {
    /// <summary>Initializes a new instance of the DoubleCollection class.</summary>
    [MethodImpl]
    public extern DoubleCollection();

    [MethodImpl]
    public extern double GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<double> GetView();

    [MethodImpl]
    public extern bool IndexOf(double value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, double value);

    [MethodImpl]
    public extern void InsertAt(uint index, double value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(double value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] double[] items);

    [MethodImpl]
    public extern void ReplaceAll(double[] items);

    [MethodImpl]
    public extern IIterator<double> First();
  }
}
