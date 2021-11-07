// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.PasswordCredentialPropertyStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the password credential property store. This class and its members are reserved for internal use and are not intended to be used in your code.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PasswordCredentialPropertyStore : 
    IPropertySet,
    IObservableMap<string, object>,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    /// <summary>This method is reserved for internal use and is not intended to be used in your code.</summary>
    [MethodImpl]
    public extern PasswordCredentialPropertyStore();

    /// <summary>This method is reserved for internal use and is not intended to be used in your code.</summary>
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
