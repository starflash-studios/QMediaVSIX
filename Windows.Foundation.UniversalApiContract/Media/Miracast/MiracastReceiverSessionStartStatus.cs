// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverSessionStartStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>The status of a Start or StartAsync operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverSessionStartStatus
  {
    /// <summary>The Miracast Receiver started successfully.</summary>
    Success,
    /// <summary>The Miracast Receiver Session could not be started due an unknown error.</summary>
    UnknownFailure,
    /// <summary>The Miracast Receiver Session cannot start because Miracast is not supported on the current device.</summary>
    MiracastNotSupported,
    /// <summary>The app is not allowed to start a Miracast Receiver Session.</summary>
    AccessDenied,
  }
}
