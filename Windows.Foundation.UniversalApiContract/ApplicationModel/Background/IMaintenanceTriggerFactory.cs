// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IMaintenanceTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (MaintenanceTrigger))]
  [Guid(1262345006, 38877, 17961, 136, 176, 176, 108, 249, 72, 42, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMaintenanceTriggerFactory
  {
    MaintenanceTrigger Create(uint freshnessTime, bool oneShot);
  }
}
