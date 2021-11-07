// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection
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
  /// <summary>Represents a collection of ColorKeyFrame objects that can be individually accessed by index. ColorKeyFrameCollection is the value of the ColorAnimationUsingKeyFrames.KeyFrames property.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class ColorKeyFrameCollection : IVector<ColorKeyFrame>, IIterable<ColorKeyFrame>
  {
    /// <summary>Initializes a new instance of the ColorKeyFrameCollection class.</summary>
    [MethodImpl]
    public extern ColorKeyFrameCollection();

    [MethodImpl]
    public extern ColorKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ColorKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(ColorKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ColorKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, ColorKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ColorKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ColorKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(ColorKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<ColorKeyFrame> First();
  }
}
