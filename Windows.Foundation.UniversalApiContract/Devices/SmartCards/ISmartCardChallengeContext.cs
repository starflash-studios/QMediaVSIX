// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardChallengeContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(422204185, 51652, 18759, 129, 204, 68, 121, 74, 97, 239, 145)]
  [ExclusiveTo(typeof (SmartCardChallengeContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardChallengeContext : IClosable
  {
    IBuffer Challenge { get; }

    [RemoteAsync]
    IAsyncOperation<bool> VerifyResponseAsync(IBuffer response);

    [RemoteAsync]
    [Overload("ProvisionAsync")]
    IAsyncAction ProvisionAsync(IBuffer response, bool formatCard);

    [Overload("ProvisionAsyncWithNewCardId")]
    [RemoteAsync]
    IAsyncAction ProvisionAsync(IBuffer response, bool formatCard, Guid newCardId);

    [RemoteAsync]
    IAsyncAction ChangeAdministrativeKeyAsync(
      IBuffer response,
      IBuffer newAdministrativeKey);
  }
}
