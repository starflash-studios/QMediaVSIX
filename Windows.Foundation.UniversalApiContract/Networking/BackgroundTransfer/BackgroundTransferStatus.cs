// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Defines transfer operation status values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTransferStatus
  {
    /// <summary>The application is idle.</summary>
    Idle = 0,
    /// <summary>The transfer is currently in progress.</summary>
    Running = 1,
    /// <summary>The application has paused the transfer operation.</summary>
    PausedByApplication = 2,
    /// <summary>The transfer operation is paused due to cost policy (for example, transitioned to a costed network).</summary>
    PausedCostedNetwork = 3,
    /// <summary>The transfer operation is paused due to a lack of network connectivity.</summary>
    PausedNoNetwork = 4,
    /// <summary>The transfer operation has completed.</summary>
    Completed = 5,
    /// <summary>The transfer operation has been cancelled.</summary>
    Canceled = 6,
    /// <summary>An error was encountered during the transfer operation.</summary>
    Error = 7,
    /// <summary>One of the app-configured recoverable web error statuses (RecoverableWebErrorStatuses ).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] PausedRecoverableWebErrorStatus = 8,
    /// <summary>The transfer is paused by the system due to resource constraints. Examples of constraints include the system being on Battery Saver when the application is not in the foreground. In Windows Phone, transfers will have this status if Battery Saver is activated, if the background task can't get enough memory, CPU, power resources to run, or if the network condition is 2G and the app is not in the foreground</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PausedSystemPolicy = 32, // 0x00000020
  }
}
