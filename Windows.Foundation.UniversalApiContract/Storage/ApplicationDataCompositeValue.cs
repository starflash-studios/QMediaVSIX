// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationDataCompositeValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents related app settings that must be serialized and deserialized atomically.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationDataCompositeValue : 
    IPropertySet,
    IObservableMap<string, object>,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    /// <summary>Creates and initializes a new, initially empty, instance of the object.</summary>
    [MethodImpl]
    public extern ApplicationDataCompositeValue();

    /// <summary>Occurs when the map changes.</summary>
    public extern event MapChangedEventHandler<string, object> MapChanged;

    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, object> GetView();

    [MethodImpl]
    public extern bool Insert(string key, object value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();
  }
}
