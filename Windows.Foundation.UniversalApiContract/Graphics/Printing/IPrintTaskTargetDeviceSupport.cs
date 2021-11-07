// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskTargetDeviceSupport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(693989568, 49867, 19325, 176, 234, 147, 9, 80, 145, 162, 32)]
  [ExclusiveTo(typeof (PrintTask))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskTargetDeviceSupport
  {
    bool IsPrinterTargetEnabled { set; get; }

    bool Is3DManufacturingTargetEnabled { set; get; }
  }
}
