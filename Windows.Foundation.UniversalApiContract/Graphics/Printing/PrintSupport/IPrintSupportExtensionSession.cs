// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportExtensionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintSupport
{
  [ExclusiveTo(typeof (PrintSupportExtensionSession))]
  [Guid(4003749658, 62662, 21683, 160, 184, 165, 89, 131, 154, 164, 195)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintSupportExtensionSession
  {
    IppPrintDevice Printer { get; }

    event TypedEventHandler<PrintSupportExtensionSession, PrintSupportPrintTicketValidationRequestedEventArgs> PrintTicketValidationRequested;

    event TypedEventHandler<PrintSupportExtensionSession, PrintSupportPrintDeviceCapabilitiesChangedEventArgs> PrintDeviceCapabilitiesChanged;

    void Start();
  }
}
