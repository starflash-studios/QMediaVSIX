// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.FileUpdateRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Provides information about a requested file update so that the app can complete the request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileUpdateRequest : IFileUpdateRequest, IFileUpdateRequest2
  {
    /// <summary>Gets the unique identifier used to associate the local version of a file with the corresponding remote version.</summary>
    /// <returns>The identifier that was specified by the app and is associated with the local file.</returns>
    public extern string ContentId { [MethodImpl] get; }

    /// <summary>Gets a StorageFile object that represents the locally cached copy of the file to update.</summary>
    /// <returns>The StorageFile object that represents the locally cached copy of the file to update.</returns>
    public extern StorageFile File { [MethodImpl] get; }

    /// <summary>Gets or sets the status of the update. This property is set in response to a FileUpdateRequested event.</summary>
    /// <returns>An enum value that indicates the status of the update.</returns>
    public extern FileUpdateStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object used to complete an update asynchronously.</summary>
    /// <returns>The object that the app uses to indicate, asynchronously, that it has finished responding to a FileUpdateRequested event and that the Request is complete.</returns>
    [MethodImpl]
    public extern FileUpdateRequestDeferral GetDeferral();

    /// <summary>Provide a new version of the local file to represent the remote file.</summary>
    /// <param name="value">The new version of the local file that will represent remote file.</param>
    [MethodImpl]
    public extern void UpdateLocalFile(IStorageFile value);

    /// <summary>Gets or sets a message to the user indicating that user input is needed to complete the FileUpdateRequest.</summary>
    /// <returns>A message to the user indicating that user input is needed to complete the FileUpdateRequest.</returns>
    public extern string UserInputNeededMessage { [MethodImpl] get; [MethodImpl] set; }
  }
}
