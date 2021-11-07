// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.FileUpdateStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Describes the status of a file update request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FileUpdateStatus
  {
    /// <summary>The file update was not fully completed and should be retried.</summary>
    Incomplete,
    /// <summary>The file update was completed successfully.</summary>
    Complete,
    /// <summary>User input (like credentials) is needed to update the file.</summary>
    UserInputNeeded,
    /// <summary>The remote version of the file was not updated because the storage location wasn't available. The file remains valid and subsequent updates to the file may succeed.</summary>
    CurrentlyUnavailable,
    /// <summary>The file is now invalid and can't be updated now or in the future. For example, this could occur if the remote version of the file was deleted.</summary>
    Failed,
    /// <summary>The file update was completed successfully and the file has been renamed. For example, this could occur if the user chose to save their changes under a different file name because of conflicting changes made to the remote version of the file.</summary>
    CompleteAndRenamed,
  }
}
