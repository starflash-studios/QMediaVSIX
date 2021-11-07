// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IPushNotificationTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (PushNotificationTrigger))]
  [Guid(1842933019, 17806, 20418, 188, 46, 213, 102, 79, 119, 237, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPushNotificationTriggerFactory
  {
    PushNotificationTrigger Create(string applicationId);
  }
}
