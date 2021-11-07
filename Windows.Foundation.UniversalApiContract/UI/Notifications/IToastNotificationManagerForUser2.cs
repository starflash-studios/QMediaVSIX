// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerForUser2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(1738302647, 33195, 17090, 136, 25, 201, 88, 118, 119, 83, 244)]
  [ExclusiveTo(typeof (ToastNotificationManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastNotificationManagerForUser2
  {
    [RemoteAsync]
    IAsyncOperation<ToastNotifier> GetToastNotifierForToastCollectionIdAsync(
      string collectionId);

    [RemoteAsync]
    IAsyncOperation<ToastNotificationHistory> GetHistoryForToastCollectionIdAsync(
      string collectionId);

    [Overload("GetToastCollectionManager")]
    ToastCollectionManager GetToastCollectionManager();

    [Overload("GetToastCollectionManagerWithAppId")]
    ToastCollectionManager GetToastCollectionManager(string appId);
  }
}
