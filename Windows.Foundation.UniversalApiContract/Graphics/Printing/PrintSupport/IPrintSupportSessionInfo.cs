// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintSupport
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (PrintSupportSessionInfo))]
  [Guid(2233551279, 30589, 21481, 158, 233, 69, 211, 244, 181, 190, 156)]
  internal interface IPrintSupportSessionInfo
  {
    AppInfo SourceAppInfo { get; }

    IppPrintDevice Printer { get; }
  }
}
