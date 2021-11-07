// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.IUserDataProtectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Security.DataProtection
{
  [ExclusiveTo(typeof (UserDataProtectionManager))]
  [Guid(521347965, 46126, 19080, 148, 128, 15, 36, 9, 36, 200, 118)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IUserDataProtectionManager
  {
    [RemoteAsync]
    IAsyncOperation<UserDataStorageItemProtectionStatus> ProtectStorageItemAsync(
      IStorageItem storageItem,
      UserDataAvailability availability);

    [RemoteAsync]
    IAsyncOperation<UserDataStorageItemProtectionInfo> GetStorageItemProtectionInfoAsync(
      IStorageItem storageItem);

    [RemoteAsync]
    IAsyncOperation<IBuffer> ProtectBufferAsync(
      IBuffer unprotectedBuffer,
      UserDataAvailability availability);

    [RemoteAsync]
    IAsyncOperation<UserDataBufferUnprotectResult> UnprotectBufferAsync(
      IBuffer protectedBuffer);

    bool IsContinuedDataAvailabilityExpected(UserDataAvailability availability);

    event TypedEventHandler<UserDataProtectionManager, UserDataAvailabilityStateChangedEventArgs> DataAvailabilityStateChanged;
  }
}
