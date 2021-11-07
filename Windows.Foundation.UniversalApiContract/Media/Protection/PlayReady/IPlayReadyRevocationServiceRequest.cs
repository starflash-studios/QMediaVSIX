// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyRevocationServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyRevocationServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1413310124, 64240, 17760, 132, 165, 14, 74, 206, 201, 57, 228)]
  internal interface IPlayReadyRevocationServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
  }
}
