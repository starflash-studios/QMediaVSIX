// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColumnDefinitionCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides access to an ordered, strongly typed collection of ColumnDefinition objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ColumnDefinitionCollection : 
    IVector<ColumnDefinition>,
    IIterable<ColumnDefinition>
  {
    [MethodImpl]
    public extern ColumnDefinition GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ColumnDefinition> GetView();

    [MethodImpl]
    public extern bool IndexOf(ColumnDefinition value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ColumnDefinition value);

    [MethodImpl]
    public extern void InsertAt(uint index, ColumnDefinition value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ColumnDefinition value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ColumnDefinition[] items);

    [MethodImpl]
    public extern void ReplaceAll(ColumnDefinition[] items);

    [MethodImpl]
    public extern IIterator<ColumnDefinition> First();
  }
}
