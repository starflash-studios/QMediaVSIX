// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Manages the syncing of chat messages.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatSyncManager : IChatSyncManager
  {
    /// <summary>The configuration properties of the sync manager.</summary>
    /// <returns>Gets the configuration properties of the sync manager.</returns>
    public extern ChatSyncConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Sets the WebAccount, which will be used by the sync manager to sync messages.</summary>
    /// <param name="webAccount">The web account.</param>
    /// <returns>An asynchronous action that doesn't return anything.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AssociateAccountAsync(WebAccount webAccount);

    /// <summary>Clears the account information and stops the sync manager from syncing messages. This will trigger a message deletion operation.</summary>
    /// <returns>An asynchronous action that doesn't return anything.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnassociateAccountAsync();

    /// <summary>Checks if a specific WebAccount is the account used by the sync manager to sync messages.</summary>
    /// <param name="webAccount">The web account.</param>
    /// <returns>True if the WebAccount is the account used by the sync manager to sync message, false otherwise.</returns>
    [MethodImpl]
    public extern bool IsAccountAssociated(WebAccount webAccount);

    /// <summary>Starts a new sync operation without waiting for the sync to finish.</summary>
    [MethodImpl]
    public extern void StartSync();

    /// <summary>Sets the configuration properties of the sync manager.</summary>
    /// <param name="configuration">The configuration.</param>
    /// <returns>An asynchronous action that doesn't return anything.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetConfigurationAsync(ChatSyncConfiguration configuration);
  }
}
