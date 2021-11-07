// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(374199255, 29636, 17655, 180, 255, 251, 109, 75, 241, 244, 198)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ToastCollection))]
  internal interface IToastCollectionFactory
  {
    ToastCollection CreateInstance(
      string collectionId,
      string displayName,
      string launchArgs,
      Uri iconUri);
  }
}
