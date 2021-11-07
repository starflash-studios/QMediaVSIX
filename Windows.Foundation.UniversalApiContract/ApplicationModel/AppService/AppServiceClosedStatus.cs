// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceClosedStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Describes the status that was set when the endpoint for the app service was closed. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppServiceClosedStatus
  {
    /// <summary>The endpoint for the app service closed gracefully.</summary>
    Completed,
    /// <summary>The endpoint for the app service was closed by the client or the system</summary>
    Canceled,
    /// <summary>The endpoint for the app service was closed because the endpoint ran out of resources.</summary>
    ResourceLimitsExceeded,
    /// <summary>An unknown error occurred.</summary>
    Unknown,
  }
}
