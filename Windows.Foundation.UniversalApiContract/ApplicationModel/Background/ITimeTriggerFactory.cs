// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ITimeTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimeTrigger))]
  [Guid(952533758, 39764, 17894, 178, 243, 38, 155, 135, 166, 247, 52)]
  internal interface ITimeTriggerFactory
  {
    TimeTrigger Create(uint freshnessTime, bool oneShot);
  }
}
