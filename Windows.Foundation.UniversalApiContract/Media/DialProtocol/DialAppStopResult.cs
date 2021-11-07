// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialAppStopResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>The result of attempting to stop an app from running on a remote device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DialAppStopResult
  {
    /// <summary>The app is successfully stopped.</summary>
    Stopped,
    /// <summary>The app failed to stop.</summary>
    StopFailed,
    /// <summary>The app cannot be stopped because the operation isn't supported.</summary>
    OperationNotSupported,
    /// <summary>An error occurred while attempting to retrieve the state.</summary>
    NetworkFailure,
  }
}
