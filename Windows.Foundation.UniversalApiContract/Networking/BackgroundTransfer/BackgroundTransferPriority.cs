// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Indicates the priority that a BackgroundTransfer operation(download or upload) has in terms of scheduling within an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTransferPriority
  {
    /// <summary>Default priority setting for an operation. By default when a new operation is created, it is placed at the end of the current transfer queue.</summary>
    Default,
    /// <summary>High priority setting for an operation. Ensures that the operation doesn't get placed at the very end of the queue, and is instead placed near the front.</summary>
    High,
    /// <summary>Low priority setting for an operation. Ensures that the operation doesn't get placed at the very front of the queue, and is instead placed near the end.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] Low,
  }
}
