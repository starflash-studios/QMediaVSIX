// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to move a folder.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxMoveFolderRequest : IEmailMailboxMoveFolderRequest
  {
    /// <summary>Gets the mailbox ID of the mailbox containing the folder to be moved.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the folder ID of the folder to be moved.</summary>
    /// <returns>A folder ID.</returns>
    public extern string EmailFolderId { [MethodImpl] get; }

    /// <summary>Gets the parent folder ID of the new parent folder.</summary>
    /// <returns>A folder ID. Note that you rename a folder by requesting a move to the current parent folder, but with a new name.</returns>
    public extern string NewParentFolderId { [MethodImpl] get; }

    /// <summary>Gets the new folder name of the file to be moved.</summary>
    /// <returns>The new folder name. Note that you rename a folder by requesting a move to the current parent folder, but with a new name.</returns>
    public extern string NewFolderName { [MethodImpl] get; }

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous move operation on an EmailMailboxMoveFolderRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous move operation on an EmailMailboxMoveFolderRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
