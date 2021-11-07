// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomainJoinServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(387664474, 16479, 18233, 176, 64, 103, 185, 240, 195, 135, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadyDomainJoinServiceRequest))]
  internal interface IPlayReadyDomainJoinServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid DomainAccountId { get; set; }

    string DomainFriendlyName { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
