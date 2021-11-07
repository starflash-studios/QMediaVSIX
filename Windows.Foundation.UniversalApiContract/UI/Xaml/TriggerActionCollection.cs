// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TriggerActionCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a collection of BeginStoryboard objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TriggerActionCollection : IVector<TriggerAction>, IIterable<TriggerAction>
  {
    /// <summary>Initializes a new instance of the TriggerActionCollection class.</summary>
    [MethodImpl]
    public extern TriggerActionCollection();

    [MethodImpl]
    public extern TriggerAction GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<TriggerAction> GetView();

    [MethodImpl]
    public extern bool IndexOf(TriggerAction value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, TriggerAction value);

    [MethodImpl]
    public extern void InsertAt(uint index, TriggerAction value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(TriggerAction value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] TriggerAction[] items);

    [MethodImpl]
    public extern void ReplaceAll(TriggerAction[] items);

    [MethodImpl]
    public extern IIterator<TriggerAction> First();
  }
}
