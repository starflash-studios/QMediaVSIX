// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PlayReadyLicenseAcquisitionServiceRequest))]
  [Guid(3086638773, 65036, 45605, 188, 96, 90, 158, 221, 50, 206, 181)]
  internal interface IPlayReadyLicenseAcquisitionServiceRequest2 : 
    IPlayReadyLicenseAcquisitionServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid SessionId { get; }
  }
}
