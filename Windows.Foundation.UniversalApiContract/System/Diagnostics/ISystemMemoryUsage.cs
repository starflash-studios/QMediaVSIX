// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemMemoryUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(402638229, 5890, 18895, 170, 39, 47, 10, 50, 89, 20, 4)]
  [ExclusiveTo(typeof (SystemMemoryUsage))]
  internal interface ISystemMemoryUsage
  {
    SystemMemoryUsageReport GetReport();
  }
}
