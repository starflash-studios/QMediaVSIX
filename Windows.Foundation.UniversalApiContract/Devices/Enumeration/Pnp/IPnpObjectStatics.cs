// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [Guid(3015911997, 53608, 18016, 187, 243, 167, 51, 177, 75, 110, 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PnpObject))]
  internal interface IPnpObjectStatics
  {
    IAsyncOperation<PnpObject> CreateFromIdAsync(
      PnpObjectType type,
      string id,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsync")]
    IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsyncAqsFilter")]
    IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);

    [Overload("CreateWatcher")]
    PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("CreateWatcherAqsFilter")]
    PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);
  }
}
