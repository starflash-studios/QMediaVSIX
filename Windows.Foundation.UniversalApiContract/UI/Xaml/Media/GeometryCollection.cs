// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeometryCollection
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
  /// <summary>Represents a collection of Geometry objects.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GeometryCollection : IVector<Geometry>, IIterable<Geometry>
  {
    /// <summary>Initializes a new instance of the GeometryCollection class.</summary>
    [MethodImpl]
    public extern GeometryCollection();

    [MethodImpl]
    public extern Geometry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Geometry> GetView();

    [MethodImpl]
    public extern bool IndexOf(Geometry value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Geometry value);

    [MethodImpl]
    public extern void InsertAt(uint index, Geometry value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Geometry value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Geometry[] items);

    [MethodImpl]
    public extern void ReplaceAll(Geometry[] items);

    [MethodImpl]
    public extern IIterator<Geometry> First();
  }
}
