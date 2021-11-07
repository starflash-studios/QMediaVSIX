// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyLicenseAcquisitionServiceRequest))]
  [Guid(961437517, 32629, 17165, 178, 231, 127, 117, 243, 75, 45, 117)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPlayReadyLicenseAcquisitionServiceRequest3 : 
    IPlayReadyLicenseAcquisitionServiceRequest2,
    IPlayReadyLicenseAcquisitionServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
