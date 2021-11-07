// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IUserProfilePersonalizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System.UserProfile
{
  [Guid(2364398260, 31128, 18133, 141, 211, 24, 79, 28, 95, 154, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserProfilePersonalizationSettings))]
  internal interface IUserProfilePersonalizationSettings
  {
    [RemoteAsync]
    IAsyncOperation<bool> TrySetLockScreenImageAsync(StorageFile imageFile);

    [RemoteAsync]
    IAsyncOperation<bool> TrySetWallpaperImageAsync(StorageFile imageFile);
  }
}
