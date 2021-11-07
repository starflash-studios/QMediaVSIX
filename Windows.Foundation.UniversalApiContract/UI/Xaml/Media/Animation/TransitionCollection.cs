// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.TransitionCollection
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
  /// <summary>Represents a collection of Transition objects. Each Transition object represents a different theme transition, part of the Windows Runtime animation library.</summary>
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TransitionCollection : IVector<Transition>, IIterable<Transition>
  {
    /// <summary>Initializes a new instance of the TransitionCollection class.</summary>
    [MethodImpl]
    public extern TransitionCollection();

    [MethodImpl]
    public extern Transition GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Transition> GetView();

    [MethodImpl]
    public extern bool IndexOf(Transition value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Transition value);

    [MethodImpl]
    public extern void InsertAt(uint index, Transition value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Transition value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Transition[] items);

    [MethodImpl]
    public extern void ReplaceAll(Transition[] items);

    [MethodImpl]
    public extern IIterator<Transition> First();
  }
}
