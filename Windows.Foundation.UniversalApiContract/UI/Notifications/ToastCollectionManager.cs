// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastCollectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Provides methods for creating, retrieving, updating, and removing toast collections.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class ToastCollectionManager : IToastCollectionManager
  {
    /// <summary>Starts the asynchronous creation or update of the specified toast notification group.</summary>
    /// <param name="collection">The toast notification group to create or update.</param>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveToastCollectionAsync(ToastCollection collection);

    /// <summary>Starts the retrieval of all toast notification groups created by this manager.</summary>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ToastCollection>> FindAllToastCollectionsAsync();

    /// <summary>Starts the retrieval of the specified notification group.</summary>
    /// <param name="collectionId">The ID of the notification group to retrieve.</param>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastCollection> GetToastCollectionAsync(
      string collectionId);

    /// <summary>Starts the asynchronous removal of the specified toast notification group.</summary>
    /// <param name="collectionId">The ID of toast notification group to remove.</param>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveToastCollectionAsync(string collectionId);

    /// <summary>Starts the asynchronous removal of all toast notification groups for the app.</summary>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveAllToastCollectionsAsync();

    /// <summary>Gets the user who receives the toast notification groups created by this toast collection manager.</summary>
    /// <returns>The user who receives the toast notification groups.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the ID of the app to which this manager belongs.</summary>
    /// <returns>The ID of the app to which this manager is bound.</returns>
    public extern string AppId { [MethodImpl] get; }
  }
}
