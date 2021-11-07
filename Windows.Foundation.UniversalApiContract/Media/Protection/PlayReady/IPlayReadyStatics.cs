// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [Guid(1583988749, 9340, 18074, 143, 49, 92, 26, 21, 113, 217, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyStatics
  {
    Guid DomainJoinServiceRequestType { get; }

    Guid DomainLeaveServiceRequestType { get; }

    Guid IndividualizationServiceRequestType { get; }

    Guid LicenseAcquirerServiceRequestType { get; }

    Guid MeteringReportServiceRequestType { get; }

    Guid RevocationServiceRequestType { get; }

    Guid MediaProtectionSystemId { get; }

    uint PlayReadySecurityVersion { get; }
  }
}
