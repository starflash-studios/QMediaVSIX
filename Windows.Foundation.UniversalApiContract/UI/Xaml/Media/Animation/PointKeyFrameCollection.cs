// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointKeyFrameCollection
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
  /// <summary>Represents a collection of PointKeyFrame objects that can be individually accessed by index. PointKeyFrameCollection is the value of the PointAnimation.KeyFrames property.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointKeyFrameCollection : IVector<PointKeyFrame>, IIterable<PointKeyFrame>
  {
    /// <summary>Initializes a new instance of the PointKeyFrameCollection class.</summary>
    [MethodImpl]
    public extern PointKeyFrameCollection();

    [MethodImpl]
    public extern PointKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<PointKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(PointKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, PointKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, PointKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(PointKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] PointKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(PointKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<PointKeyFrame> First();
  }
}
