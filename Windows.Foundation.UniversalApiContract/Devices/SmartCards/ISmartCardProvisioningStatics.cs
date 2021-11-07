// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioningStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(327690312, 3347, 20080, 151, 53, 81, 218, 236, 165, 37, 79)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  internal interface ISmartCardProvisioningStatics
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardProvisioning> FromSmartCardAsync(
      SmartCard card);

    [Overload("RequestVirtualSmartCardCreationAsync")]
    IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    [Overload("RequestVirtualSmartCardCreationAsyncWithCardId")]
    IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync(SmartCard card);
  }
}
