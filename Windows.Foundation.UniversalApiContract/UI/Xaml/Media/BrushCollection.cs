// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.BrushCollection
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
  /// <summary>Represents an ordered collection of Brush values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class BrushCollection : IVector<Brush>, IIterable<Brush>
  {
    /// <summary>Initializes a new instance of the BrushCollection class.</summary>
    [MethodImpl]
    public extern BrushCollection();

    [MethodImpl]
    public extern Brush GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Brush> GetView();

    [MethodImpl]
    public extern bool IndexOf(Brush value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Brush value);

    [MethodImpl]
    public extern void InsertAt(uint index, Brush value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Brush value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Brush[] items);

    [MethodImpl]
    public extern void ReplaceAll(Brush[] items);

    [MethodImpl]
    public extern IIterator<Brush> First();
  }
}
