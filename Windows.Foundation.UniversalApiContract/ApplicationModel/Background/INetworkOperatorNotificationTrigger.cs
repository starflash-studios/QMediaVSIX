// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.INetworkOperatorNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (NetworkOperatorNotificationTrigger))]
  [Guid(2416483526, 25549, 18444, 149, 209, 110, 106, 239, 128, 30, 74)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkOperatorNotificationTrigger : IBackgroundTrigger
  {
    string NetworkAccountId { get; }
  }
}
