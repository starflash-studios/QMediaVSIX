// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.INetworkOperatorNotificationTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (NetworkOperatorNotificationTrigger))]
  [Guid(170016256, 10199, 17235, 173, 185, 146, 101, 170, 234, 87, 157)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkOperatorNotificationTriggerFactory
  {
    NetworkOperatorNotificationTrigger Create(
      string networkAccountId);
  }
}
