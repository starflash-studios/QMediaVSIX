// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.MapChangedEventHandler`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents the method that handles the changed event of an observable map.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  /// <typeparam name="V">
  /// </typeparam>
  /// <param name="sender">The observable map that changed.</param>
  /// <param name="@event">
  /// </param>
  [Guid(395646963, 38126, 16888, 189, 220, 118, 138, 137, 85, 68, 243)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void MapChangedEventHandler<K, V>(
    IObservableMap<K, V> sender,
    IMapChangedEventArgs<K> @event);
}
