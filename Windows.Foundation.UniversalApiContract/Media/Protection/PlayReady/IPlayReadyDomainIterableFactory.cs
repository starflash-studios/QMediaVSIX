// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomainIterableFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyDomainIterable))]
  [Guid(1307804910, 12577, 19955, 165, 232, 208, 194, 76, 5, 0, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyDomainIterableFactory
  {
    PlayReadyDomainIterable CreateInstance(Guid domainAccountId);
  }
}
