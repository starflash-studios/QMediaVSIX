// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppIntegerRangeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1976888494, 63614, 21677, 181, 208, 70, 82, 4, 219, 117, 83)]
  [ExclusiveTo(typeof (IppIntegerRange))]
  internal interface IIppIntegerRangeFactory
  {
    IppIntegerRange CreateInstance(int start, int end);
  }
}
