// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.TimelineCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents a collection of Timeline objects (specific type animations). A TimelineCollection is the value of the Storyboard.Children property.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TimelineCollection : IVector<Timeline>, IIterable<Timeline>
  {
    /// <summary>Initializes a new instance of the TimelineCollection class.</summary>
    [MethodImpl]
    public extern TimelineCollection();

    [MethodImpl]
    public extern Timeline GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Timeline> GetView();

    [MethodImpl]
    public extern bool IndexOf(Timeline value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Timeline value);

    [MethodImpl]
    public extern void InsertAt(uint index, Timeline value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Timeline value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Timeline[] items);

    [MethodImpl]
    public extern void ReplaceAll(Timeline[] items);

    [MethodImpl]
    public extern IIterator<Timeline> First();
  }
}
