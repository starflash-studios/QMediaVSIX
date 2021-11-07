// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents a set of background transfer operations (DownloadOperation or UploadOperation objects) that trigger a background task once all the operations are done (if the operations completed successfully) or fail with an error.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundTransferCompletionGroup : IBackgroundTransferCompletionGroup
  {
    /// <summary>Creates a new BackgroundTransferCompletionGroup object.</summary>
    [MethodImpl]
    public extern BackgroundTransferCompletionGroup();

    /// <summary>Gets the IBackgroundTrigger used to set up the background task associated with the BackgroundTransferCompletionGroup.</summary>
    /// <returns>The trigger used to set up the background task associated with the BackgroundTransferCompletionGroup.</returns>
    public extern IBackgroundTrigger Trigger { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if Enable method on a BackgroundTransferCompletionGroup has already been called.</summary>
    /// <returns>A value that indicates if the Enable method on the BackgroundTransferCompletionGroup has already been called.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Indicates that the BackgroundTransferCompletionGroup is complete and no more background transfer operations (DownloadOperation or UploadOperation objects) will be added t the completion group.</summary>
    [MethodImpl]
    public extern void Enable();
  }
}
