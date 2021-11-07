// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IEmailStoreNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2557282010, 18411, 17000, 164, 242, 243, 247, 113, 136, 56, 138)]
  [ExclusiveTo(typeof (EmailStoreNotificationTrigger))]
  internal interface IEmailStoreNotificationTrigger : IBackgroundTrigger
  {
  }
}
