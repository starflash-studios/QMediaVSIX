// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IToastNotificationHistoryChangedTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (ToastNotificationHistoryChangedTrigger))]
  [Guid(2177301165, 34711, 18309, 129, 180, 176, 204, 203, 115, 209, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationHistoryChangedTriggerFactory
  {
    ToastNotificationHistoryChangedTrigger Create(
      string applicationId);
  }
}
