// Decompiled with JetBrains decompiler
// Type: Windows.Storage.UserDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Returns full paths for common user data folders. User data folders are based on the KNOWNFOLDERID naming pattern.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserDataPathsStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataPaths : IUserDataPaths
  {
    /// <summary>Gets the path to a user's Camera Roll folder.</summary>
    /// <returns>The full path to the user's Camera Roll folder.</returns>
    public extern string CameraRoll { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Cookies app data folder.</summary>
    /// <returns>The full path to the user's Cookies app data folder.</returns>
    public extern string Cookies { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Desktop folder.</summary>
    /// <returns>The full path to the user's Desktop folder.</returns>
    public extern string Desktop { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Documents folder.</summary>
    /// <returns>The full path to the user's Documents folder.</returns>
    public extern string Documents { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Downloads folder.</summary>
    /// <returns>The full path to the user's Downloads folder.</returns>
    public extern string Downloads { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Favorites folder.</summary>
    /// <returns>The full path to the user's Favorites folder.</returns>
    public extern string Favorites { [MethodImpl] get; }

    /// <summary>Gets the path to a user's History folder.</summary>
    /// <returns>The full path to the user's History folder.</returns>
    public extern string History { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Temporary Internet Files folder.</summary>
    /// <returns>The full path to the user's Temporary Internet Files folder.</returns>
    public extern string InternetCache { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Local app data folder.</summary>
    /// <returns>The full path to the user's Local app data folder.</returns>
    public extern string LocalAppData { [MethodImpl] get; }

    /// <summary>Gets the path to a user's LocalLow app data folder.</summary>
    /// <returns>The full path to the user's LocalLow app data folder.</returns>
    public extern string LocalAppDataLow { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Music folder.</summary>
    /// <returns>The full path to the user's Music folder.</returns>
    public extern string Music { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Pictures folder.</summary>
    /// <returns>The full path to the user's Pictures folder.</returns>
    public extern string Pictures { [MethodImpl] get; }

    /// <summary>Gets the path to a user's profile on the machine.</summary>
    /// <returns>The full path to the user's profile folder.</returns>
    public extern string Profile { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Recent Items folder.</summary>
    /// <returns>The full path to the user's Recent Items folder.</returns>
    public extern string Recent { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Roaming app data folder.</summary>
    /// <returns>The full path to the user's Roaming app data folder.</returns>
    public extern string RoamingAppData { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Saved Pictures folder.</summary>
    /// <returns>The full path to the user's Saved Pictures folder.</returns>
    public extern string SavedPictures { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Screenshots folder.</summary>
    /// <returns>The full path to the user's Screenshots folder.</returns>
    public extern string Screenshots { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Common Templates folder.</summary>
    /// <returns>The full path to the user's Common Templates folder.</returns>
    public extern string Templates { [MethodImpl] get; }

    /// <summary>Gets the path to a user's Videos folder.</summary>
    /// <returns>The full path to the user's Videos folder.</returns>
    public extern string Videos { [MethodImpl] get; }

    /// <summary>Gets the paths to a user's various data folders. Use this method for multi-user machines.</summary>
    /// <param name="user">The user to retreive the paths for.</param>
    /// <returns>The data folders associated with the user.</returns>
    [MethodImpl]
    public static extern UserDataPaths GetForUser(User user);

    /// <summary>Gets the paths to a user's various data folders. Use this method for single user machines.</summary>
    /// <returns>The data folders associated with the user.</returns>
    [MethodImpl]
    public static extern UserDataPaths GetDefault();
  }
}
