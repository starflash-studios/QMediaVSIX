// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.UserProfilePersonalizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System.UserProfile
{
  /// <summary>Provides properties and methods to manage the user's desktop wallpaper and lock screen background image.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserProfilePersonalizationSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UserProfilePersonalizationSettings : IUserProfilePersonalizationSettings
  {
    /// <summary>Attempts to set the specified image file as the lock screen background image.</summary>
    /// <param name="imageFile">The image to set as the lock screen background.</param>
    /// <returns>The result of the async operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetLockScreenImageAsync(
      StorageFile imageFile);

    /// <summary>Attempts to set the specified image file as the desktop wallpaper image.</summary>
    /// <param name="imageFile">The image to set as the desktop background.</param>
    /// <returns>The result of the async operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetWallpaperImageAsync(
      StorageFile imageFile);

    /// <summary>Gets the current instance of UserProfilePersonalizationSettings.</summary>
    /// <returns>The current instance of UserProfilePersonalizationSettings.</returns>
    public static extern UserProfilePersonalizationSettings Current { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether changing the desktop and lock screen images is supported on the current device.</summary>
    /// <returns>**true** if changing the desktop and lock screen images is supported; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
