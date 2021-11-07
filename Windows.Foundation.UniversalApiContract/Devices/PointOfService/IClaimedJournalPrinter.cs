// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedJournalPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClaimedJournalPrinter))]
  [Guid(1743390256, 20861, 18559, 159, 223, 210, 224, 160, 162, 100, 165)]
  internal interface IClaimedJournalPrinter
  {
    JournalPrintJob CreateJob();
  }
}
