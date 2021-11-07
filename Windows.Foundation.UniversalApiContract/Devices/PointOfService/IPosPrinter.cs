// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinter))]
  [Guid(704889102, 39449, 18945, 153, 79, 18, 223, 173, 106, 220, 191)]
  internal interface IPosPrinter
  {
    string DeviceId { get; }

    PosPrinterCapabilities Capabilities { get; }

    IVectorView<uint> SupportedCharacterSets { get; }

    IVectorView<string> SupportedTypeFaces { get; }

    PosPrinterStatus Status { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedPosPrinter> ClaimPrinterAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<string> GetStatisticsAsync(IIterable<string> statisticsCategories);

    event TypedEventHandler<PosPrinter, PosPrinterStatusUpdatedEventArgs> StatusUpdated;
  }
}
