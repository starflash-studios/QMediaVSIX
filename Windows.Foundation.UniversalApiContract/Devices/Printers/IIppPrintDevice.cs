// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppPrintDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [Guid(3611864150, 30451, 24006, 175, 212, 194, 168, 104, 107, 147, 89)]
  [ExclusiveTo(typeof (IppPrintDevice))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IIppPrintDevice
  {
    string PrinterName { get; }

    Uri PrinterUri { get; }

    IBuffer GetPrinterAttributesAsBuffer(IIterable<string> attributeNames);

    IMap<string, IppAttributeValue> GetPrinterAttributes(
      IIterable<string> attributeNames);

    IppSetAttributesResult SetPrinterAttributesFromBuffer(
      IBuffer printerAttributesBuffer);

    IppSetAttributesResult SetPrinterAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> printerAttributes);
  }
}
