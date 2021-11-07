// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioningStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(877119144, 51616, 19414, 181, 13, 37, 31, 78, 141, 58, 98)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardProvisioningStatics2
  {
    [Overload("RequestAttestedVirtualSmartCardCreationAsync")]
    IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    [Overload("RequestAttestedVirtualSmartCardCreationAsyncWithCardId")]
    IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);
  }
}
