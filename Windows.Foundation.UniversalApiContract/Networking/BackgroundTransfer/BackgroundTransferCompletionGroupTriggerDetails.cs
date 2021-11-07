// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroupTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Contains information about a BackgroundTransferCompletionGroup that can be only accessed from the Run method on the IBackgroundTask.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BackgroundTransferCompletionGroupTriggerDetails : 
    IBackgroundTransferCompletionGroupTriggerDetails
  {
    /// <summary>Gets the list of DownloadOperation objects associated with the BackgroundTransferCompletionGroup.</summary>
    /// <returns>The list of DownloadOperation objects associated with the BackgroundTransferCompletionGroup</returns>
    public extern IVectorView<DownloadOperation> Downloads { [MethodImpl] get; }

    /// <summary>Gets the list of UploadOperation objects associated with the BackgroundTransferCompletionGroup.</summary>
    /// <returns>The list of UploadOperation objects associated with the BackgroundTransferCompletionGroup.</returns>
    public extern IVectorView<UploadOperation> Uploads { [MethodImpl] get; }
  }
}
