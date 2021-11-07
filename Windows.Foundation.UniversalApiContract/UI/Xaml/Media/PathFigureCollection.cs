// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PathFigureCollection
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
  /// <summary>Represents a collection of PathFigure objects that collectively make up the geometry of a PathGeometry.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PathFigureCollection : IVector<PathFigure>, IIterable<PathFigure>
  {
    /// <summary>Initializes a new instance of the PathFigureCollection class.</summary>
    [MethodImpl]
    public extern PathFigureCollection();

    [MethodImpl]
    public extern PathFigure GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<PathFigure> GetView();

    [MethodImpl]
    public extern bool IndexOf(PathFigure value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, PathFigure value);

    [MethodImpl]
    public extern void InsertAt(uint index, PathFigure value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(PathFigure value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] PathFigure[] items);

    [MethodImpl]
    public extern void ReplaceAll(PathFigure[] items);

    [MethodImpl]
    public extern IIterator<PathFigure> First();
  }
}
