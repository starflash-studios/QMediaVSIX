// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomainLeaveServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyDomainLeaveServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(103635134, 38829, 18711, 170, 3, 70, 212, 194, 82, 212, 100)]
  internal interface IPlayReadyDomainLeaveServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid DomainAccountId { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
