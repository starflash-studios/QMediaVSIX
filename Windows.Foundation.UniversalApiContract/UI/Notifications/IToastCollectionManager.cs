// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastCollectionManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(706224638, 6045, 18876, 183, 157, 165, 39, 146, 13, 54, 101)]
  internal interface IToastCollectionManager
  {
    [RemoteAsync]
    IAsyncAction SaveToastCollectionAsync(ToastCollection collection);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ToastCollection>> FindAllToastCollectionsAsync();

    [RemoteAsync]
    IAsyncOperation<ToastCollection> GetToastCollectionAsync(
      string collectionId);

    [RemoteAsync]
    IAsyncAction RemoveToastCollectionAsync(string collectionId);

    [RemoteAsync]
    IAsyncAction RemoveAllToastCollectionsAsync();

    User User { get; }

    string AppId { get; }
  }
}
