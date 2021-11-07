// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FilePickerFileTypesOrderedMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  /// <summary>Represents a collection of display names mapped to the associated file types (extensions). Each element in this collection maps a display name to a corresponding collection of file name extensions. The key is a single string, the value is a list/vector of strings representing one or more extension choices.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FilePickerFileTypesOrderedMap : 
    IMap<string, IVector<string>>,
    IIterable<IKeyValuePair<string, IVector<string>>>
  {
    [MethodImpl]
    public extern IVector<string> Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, IVector<string>> GetView();

    [MethodImpl]
    public extern bool Insert(string key, IVector<string> value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, IVector<string>>> First();
  }
}
