// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceQualifierObservableMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Notifies listeners of dynamic changes to a map of ResourceQualifier objects, such as when items get added or removed, and allows qualifier values to change.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceQualifierObservableMap : 
    IObservableMap<string, string>,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>
  {
    /// <summary>Occurs when the map changes.</summary>
    public extern event MapChangedEventHandler<string, string> MapChanged;

    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, string> GetView();

    [MethodImpl]
    public extern bool Insert(string key, string value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();
  }
}
