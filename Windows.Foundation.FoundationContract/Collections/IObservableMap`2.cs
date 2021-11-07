// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IObservableMap`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Notifies listeners of dynamic changes to a map, such as when items are added or removed.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  /// <typeparam name="V">
  /// </typeparam>
  [Guid(1709124597, 48953, 16821, 174, 188, 90, 157, 134, 94, 71, 43)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IObservableMap<K, V> : IMap<K, V>
  {
    /// <summary>Occurs when the map changes.</summary>
    event MapChangedEventHandler<K, V> MapChanged;
  }
}
