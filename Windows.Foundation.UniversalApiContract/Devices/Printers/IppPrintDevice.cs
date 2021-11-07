// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IppPrintDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class IppPrintDevice : IIppPrintDevice
  {
    public extern string PrinterName { [MethodImpl] get; }

    public extern Uri PrinterUri { [MethodImpl] get; }

    [MethodImpl]
    public extern IBuffer GetPrinterAttributesAsBuffer(IIterable<string> attributeNames);

    [MethodImpl]
    public extern IMap<string, IppAttributeValue> GetPrinterAttributes(
      IIterable<string> attributeNames);

    [MethodImpl]
    public extern IppSetAttributesResult SetPrinterAttributesFromBuffer(
      IBuffer printerAttributesBuffer);

    [MethodImpl]
    public extern IppSetAttributesResult SetPrinterAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> printerAttributes);
  }
}
