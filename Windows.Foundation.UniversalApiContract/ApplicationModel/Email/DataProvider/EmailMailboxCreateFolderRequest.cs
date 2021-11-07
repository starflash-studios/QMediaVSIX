// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to create a folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxCreateFolderRequest : IEmailMailboxCreateFolderRequest
  {
    /// <summary>Gets the mailbox identifier for the mailbox where the new folder should be created.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the folder ID of the parent folder for the created folder.</summary>
    /// <returns>A folder ID. Get the parent folder's ID from its EmailFolder.Id property.</returns>
    public extern string ParentFolderId { [MethodImpl] get; }

    /// <summary>Gets the name of the folder to be created.</summary>
    /// <returns>A folder name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Informs the client that the request was processed successfully.</summary>
    /// <param name="folder">An EmailFolder representing the created folder.</param>
    /// <returns>An asynchronous create operation on an EmailMailboxCreateFolderRequest object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(EmailFolder folder);

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <param name="status">An EmailMailboxCreateFolderStatus value indicating why the operation failed.</param>
    /// <returns>An asynchronous create operation on an EmailMailboxCreateFolderRequest object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(EmailMailboxCreateFolderStatus status);
  }
}
