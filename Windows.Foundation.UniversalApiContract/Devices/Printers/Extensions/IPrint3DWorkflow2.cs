// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflow2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ExclusiveTo(typeof (Print3DWorkflow))]
  [Guid(2728838479, 35521, 18712, 151, 65, 227, 79, 48, 4, 35, 158)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPrint3DWorkflow2
  {
    event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrinterChangedEventArgs> PrinterChanged;
  }
}
