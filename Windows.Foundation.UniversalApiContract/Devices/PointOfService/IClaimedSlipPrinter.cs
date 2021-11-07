// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedSlipPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedSlipPrinter))]
  [Guid(3177050098, 44944, 20106, 183, 123, 227, 174, 156, 166, 58, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedSlipPrinter
  {
    uint SidewaysMaxLines { get; }

    uint SidewaysMaxChars { get; }

    uint MaxLines { get; }

    uint LinesNearEndToEnd { get; }

    PosPrinterPrintSide PrintSide { get; }

    Size PageSize { get; }

    Rect PrintArea { get; }

    void OpenJaws();

    void CloseJaws();

    [RemoteAsync]
    IAsyncOperation<bool> InsertSlipAsync(TimeSpan timeout);

    [RemoteAsync]
    IAsyncOperation<bool> RemoveSlipAsync(TimeSpan timeout);

    void ChangePrintSide(PosPrinterPrintSide printSide);

    SlipPrintJob CreateJob();
  }
}
