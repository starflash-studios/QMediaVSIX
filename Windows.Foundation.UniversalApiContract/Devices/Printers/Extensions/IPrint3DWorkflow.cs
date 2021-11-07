// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [Guid(3312415933, 13929, 19046, 171, 66, 200, 21, 25, 48, 205, 52)]
  [ExclusiveTo(typeof (Print3DWorkflow))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IPrint3DWorkflow
  {
    string DeviceID { get; }

    object GetPrintModelPackage();

    bool IsPrintReady { get; set; }

    event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrintRequestedEventArgs> PrintRequested;
  }
}
