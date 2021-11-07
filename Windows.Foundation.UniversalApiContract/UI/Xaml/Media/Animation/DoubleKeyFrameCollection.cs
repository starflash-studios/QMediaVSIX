// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection
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
  /// <summary>Represents a collection of DoubleKeyFrame objects that can be individually accessed by index. DoubleKeyFrameCollection is the value of the DoubleAnimationUsingKeyFrames.KeyFrames property.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class DoubleKeyFrameCollection : IVector<DoubleKeyFrame>, IIterable<DoubleKeyFrame>
  {
    /// <summary>Initializes a new instance of the DoubleKeyFrameCollection class.</summary>
    [MethodImpl]
    public extern DoubleKeyFrameCollection();

    [MethodImpl]
    public extern DoubleKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<DoubleKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(DoubleKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, DoubleKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, DoubleKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(DoubleKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] DoubleKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(DoubleKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<DoubleKeyFrame> First();
  }
}
