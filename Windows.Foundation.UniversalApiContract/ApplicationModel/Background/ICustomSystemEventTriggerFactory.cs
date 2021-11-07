// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICustomSystemEventTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CustomSystemEventTrigger))]
  [Guid(1808471749, 62172, 16818, 158, 253, 185, 107, 220, 209, 60, 237)]
  internal interface ICustomSystemEventTriggerFactory
  {
    CustomSystemEventTrigger Create(
      string triggerId,
      CustomSystemEventTriggerRecurrence recurrence);
  }
}
