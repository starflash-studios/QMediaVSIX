// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxEmptyFolderStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Indicates the result of a call to TryEmptyFolderAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum EmailMailboxEmptyFolderStatus
  {
    /// <summary>The folder was successfully emptied.</summary>
    Success,
    /// <summary>There was a network error while trying to empty the folder.</summary>
    NetworkError,
    /// <summary>There was a permissions error while trying to empty the folder.</summary>
    PermissionsError,
    /// <summary>There was a server error while trying to empty the folder.</summary>
    ServerError,
    /// <summary>There was an unknown error while trying to empty the folder.</summary>
    UnknownFailure,
    /// <summary>An error occurred while deleting parts of the folder.</summary>
    CouldNotDeleteEverything,
  }
}
