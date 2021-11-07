// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ObjectKeyFrameCollection
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
  /// <summary>Represents a collection of ObjectKeyFrame objects that can be individually accessed by index. ObjectKeyFrameCollection is the value of the ObjectAnimationUsingKeyFrames.KeyFrames property.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ObjectKeyFrameCollection : IVector<ObjectKeyFrame>, IIterable<ObjectKeyFrame>
  {
    /// <summary>Initializes a new instance of the ObjectKeyFrameCollection class.</summary>
    [MethodImpl]
    public extern ObjectKeyFrameCollection();

    [MethodImpl]
    public extern ObjectKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ObjectKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(ObjectKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ObjectKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, ObjectKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ObjectKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ObjectKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(ObjectKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<ObjectKeyFrame> First();
  }
}
