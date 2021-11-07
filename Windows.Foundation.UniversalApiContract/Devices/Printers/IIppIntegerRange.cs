// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppIntegerRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ExclusiveTo(typeof (IppIntegerRange))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2458940230, 50154, 24278, 189, 177, 55, 82, 198, 44, 111, 127)]
  internal interface IIppIntegerRange
  {
    int Start { get; }

    int End { get; }
  }
}
