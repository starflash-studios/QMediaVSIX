// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Manages secure stop messages.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3041926885, 447, 17409, 150, 119, 5, 99, 10, 106, 76, 200)]
  public interface IPlayReadySecureStopServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    /// <summary>Gets the secure stop session identifier property.</summary>
    /// <returns>The secure stop session identifier.</returns>
    Guid SessionID { get; }

    /// <summary>Gets the secure stop session's start time property.</summary>
    /// <returns>The secure stop session's start time.</returns>
    global::Windows.Foundation.DateTime StartTime { get; }

    /// <summary>Gets the secure stop session's update/stop time property.</summary>
    /// <returns>The secure stop session's update/stop time.</returns>
    global::Windows.Foundation.DateTime UpdateTime { get; }

    /// <summary>Gets the secure stop session's stopped flag property which indicates whether the secure stop session for this request was cleanly shut down.</summary>
    /// <returns>The secure stop session's stopped flag.</returns>
    bool Stopped { get; }

    /// <summary>Gets the current publisher certificate property.</summary>
    /// <returns>The current publisher certificate.</returns>
    byte[] PublisherCertificate { get; }
  }
}
