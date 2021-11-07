// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxCreateFolderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the result of a TryCreateFolderAsync operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailboxCreateFolderResult : IEmailMailboxCreateFolderResult
  {
    /// <summary>Gets the status of a TryCreateFolderAsync operation.</summary>
    /// <returns>The status of a TryCreateFolderAsync operation.</returns>
    public extern EmailMailboxCreateFolderStatus Status { [MethodImpl] get; }

    /// <summary>Get the newly created folder after a TryCreateFolderAsync operation.</summary>
    /// <returns>The newly created folder after a TryCreateFolderAsync operation.</returns>
    public extern EmailFolder Folder { [MethodImpl] get; }
  }
}
