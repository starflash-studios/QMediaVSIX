// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemCpuUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemCpuUsage))]
  [Guid(1614263212, 726, 16948, 131, 98, 127, 227, 173, 200, 31, 95)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemCpuUsage
  {
    SystemCpuUsageReport GetReport();
  }
}
