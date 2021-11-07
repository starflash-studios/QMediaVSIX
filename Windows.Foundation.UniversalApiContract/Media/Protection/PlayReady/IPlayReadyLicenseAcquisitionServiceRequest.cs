// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Performs a license acquisition process.</summary>
  [Guid(1569062725, 16031, 20296, 147, 225, 149, 48, 200, 213, 140, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPlayReadyLicenseAcquisitionServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    /// <summary>Gets the current content header property.</summary>
    /// <returns>The current content header property.</returns>
    PlayReadyContentHeader ContentHeader { get; set; }

    /// <summary>Gets the current domain service identifier property that overrides a service identifier in the content header.</summary>
    /// <returns>The current service identifier property.</returns>
    Guid DomainServiceId { get; set; }
  }
}
