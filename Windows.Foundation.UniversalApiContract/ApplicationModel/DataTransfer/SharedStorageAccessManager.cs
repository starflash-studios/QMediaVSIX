// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Enables an app to share a file with another app by passing a token via Uri activation, app service, REST API, etc. The target app redeems the token to get the file shared by the source app.</summary>
  [Static(typeof (ISharedStorageAccessManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class SharedStorageAccessManager
  {
    /// <summary>Gets the sharing token that enables an app to share the specified file with another app.</summary>
    /// <param name="file">The file to share with the target app.</param>
    /// <returns>The sharing token to provide to the target app .</returns>
    [MethodImpl]
    public static extern string AddFile(IStorageFile file);

    /// <summary>Gets a file shared by another app by providing the sharing token received from the source app.</summary>
    /// <param name="token">The sharing token for the shared file.</param>
    /// <returns>A wrapper object that contains the shared file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> RedeemTokenForFileAsync(
      string token);

    /// <summary>Revokes an existing sharing token.</summary>
    /// <param name="token">The sharing token to revoke.</param>
    [MethodImpl]
    public static extern void RemoveFile(string token);
  }
}
