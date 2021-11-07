// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupStateReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppResourceGroupStateReport))]
  [Guid(1384423192, 12144, 16950, 171, 64, 208, 77, 176, 199, 185, 49)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupStateReport
  {
    AppResourceGroupExecutionState ExecutionState { get; }

    AppResourceGroupEnergyQuotaState EnergyQuotaState { get; }
  }
}
