// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SetterBaseCollection
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
  /// <summary>Represents a collection of objects that inherit from SetterBase.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class SetterBaseCollection : 
    ISetterBaseCollection,
    IVector<SetterBase>,
    IIterable<SetterBase>
  {
    /// <summary>Initializes a new instance of the SetterBaseCollection class.</summary>
    [MethodImpl]
    public extern SetterBaseCollection();

    /// <summary>Gets a value that indicates whether the collection is in a read-only state.</summary>
    /// <returns>**true** if this object is in a read-only state and cannot be changed; otherwise, **false**.</returns>
    public extern bool IsSealed { [MethodImpl] get; }

    [MethodImpl]
    public extern SetterBase GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SetterBase> GetView();

    [MethodImpl]
    public extern bool IndexOf(SetterBase value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SetterBase value);

    [MethodImpl]
    public extern void InsertAt(uint index, SetterBase value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SetterBase value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SetterBase[] items);

    [MethodImpl]
    public extern void ReplaceAll(SetterBase[] items);

    [MethodImpl]
    public extern IIterator<SetterBase> First();
  }
}
