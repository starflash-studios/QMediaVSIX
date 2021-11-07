// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflowPrintRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ExclusiveTo(typeof (Print3DWorkflowPrintRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(435734616, 23240, 19285, 138, 95, 230, 21, 103, 218, 251, 77)]
  internal interface IPrint3DWorkflowPrintRequestedEventArgs
  {
    Print3DWorkflowStatus Status { get; }

    void SetExtendedStatus(Print3DWorkflowDetail value);

    void SetSource(object source);

    void SetSourceChanged(bool value);
  }
}
