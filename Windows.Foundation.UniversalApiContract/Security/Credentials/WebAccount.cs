// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.WebAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  /// <summary>Identifies an account from a web account provider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IWebAccountFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAccount : IWebAccount, IWebAccount2
  {
    /// <summary>Creates an instance of the WebAccount class.</summary>
    /// <param name="webAccountProvider">The web account provider associated with the web account.</param>
    /// <param name="userName">The user name of the web account.</param>
    /// <param name="state">The state of the web account.</param>
    [MethodImpl]
    public extern WebAccount(
      WebAccountProvider webAccountProvider,
      string userName,
      WebAccountState state);

    /// <summary>Gets the web authentication provider for the account.</summary>
    /// <returns>The web authentication provider for the account.</returns>
    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    /// <summary>Gets the username for the web account.</summary>
    /// <returns>The username for the web account.</returns>
    public extern string UserName { [MethodImpl] get; }

    /// <summary>Gets the connected state of the web account.</summary>
    /// <returns>The connected state of the web account.</returns>
    public extern WebAccountState State { [MethodImpl] get; }

    /// <summary>Gets the Id of the web account.</summary>
    /// <returns>The Id of the WebAccount.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the properties of the web account.</summary>
    /// <returns>The properties of the WebAccount.</returns>
    public extern IMapView<string, string> Properties { [MethodImpl] get; }

    /// <summary>Gets the web account's picture asynchronously.</summary>
    /// <param name="desizedSize">The desired size of the web account picture.</param>
    /// <returns>When this method completes, it returns the web account's picture.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetPictureAsync(
      WebAccountPictureSize desizedSize);

    /// <summary>Signs the web account out asynchronously. This clears all cached tokens associated with the account, and tells the provider to invalidate any tokens associated with the account for this app.</summary>
    /// <returns>This method does not return a value.</returns>
    [Overload("SignOutAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SignOutAsync();

    /// <summary>Signs the web account out asynchronously. This clears all cached tokens associated with the account, and tells the provider to invalidate any tokens associated with the account for this app.</summary>
    /// <param name="clientId">The Id of the client.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [Overload("SignOutWithClientIdAsync")]
    [MethodImpl]
    public extern IAsyncAction SignOutAsync(string clientId);
  }
}
