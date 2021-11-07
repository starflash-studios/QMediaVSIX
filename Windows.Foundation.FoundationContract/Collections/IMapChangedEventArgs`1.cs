// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMapChangedEventArgs`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Provides data for the changed event of a map collection.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  [Guid(2570712287, 1290, 19471, 170, 96, 119, 7, 95, 156, 71, 119)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IMapChangedEventArgs<K>
  {
    /// <summary>Gets the type of change that occurred in the map.</summary>
    /// <returns>The type of change in the map.</returns>
    CollectionChange CollectionChange { [MethodImpl] get; }

    /// <summary>Gets the key of the item that changed.</summary>
    /// <returns>The key of the item that changed.</returns>
    K Key { [MethodImpl] get; }
  }
}
