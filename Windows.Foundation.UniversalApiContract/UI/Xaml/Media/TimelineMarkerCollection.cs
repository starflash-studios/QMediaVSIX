// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TimelineMarkerCollection
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
  /// <summary>Represents a collection of TimelineMarker objects that can be individually accessed by index. A TimelineMarkerCollection is an ordered list where the order is determined by the Time value of each TimelineMarker item contained in the collection. For more info on how this affects the collection API, see Remarks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class TimelineMarkerCollection : IVector<TimelineMarker>, IIterable<TimelineMarker>
  {
    /// <summary>Initializes a new instance of the TimelineMarkerCollection class.</summary>
    [MethodImpl]
    public extern TimelineMarkerCollection();

    [MethodImpl]
    public extern TimelineMarker GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<TimelineMarker> GetView();

    [MethodImpl]
    public extern bool IndexOf(TimelineMarker value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, TimelineMarker value);

    [MethodImpl]
    public extern void InsertAt(uint index, TimelineMarker value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(TimelineMarker value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] TimelineMarker[] items);

    [MethodImpl]
    public extern void ReplaceAll(TimelineMarker[] items);

    [MethodImpl]
    public extern IIterator<TimelineMarker> First();
  }
}
