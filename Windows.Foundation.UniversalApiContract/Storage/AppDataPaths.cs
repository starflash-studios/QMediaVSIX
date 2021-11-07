// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AppDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>AppDataPaths returns paths to commonly used application folders based on the KNOWNFOLDERID naming pattern.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (IAppDataPathsStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppDataPaths : IAppDataPaths
  {
    /// <summary>Gets the path to the app's cookies.</summary>
    /// <returns>The full path to the app's cookies. This is the same folder that is used by the Windows Internet API.</returns>
    public extern string Cookies { [MethodImpl] get; }

    /// <summary>Gets the path to the desktop folder.</summary>
    /// <returns>The full path to the desktop folder.</returns>
    public extern string Desktop { [MethodImpl] get; }

    /// <summary>Gets a path to the documents folder.</summary>
    /// <returns>The full path to the documents folder.</returns>
    public extern string Documents { [MethodImpl] get; }

    /// <summary>Gets a path to the favorites folder.</summary>
    /// <returns>The full path to the favorites folder.</returns>
    public extern string Favorites { [MethodImpl] get; }

    /// <summary>Gets a path to the history folder.</summary>
    /// <returns>The full path to the history folder. This is the same folder that is used by the Windows Internet API.</returns>
    public extern string History { [MethodImpl] get; }

    /// <summary>Gets the path to the internet cache folder.</summary>
    /// <returns>The full path to the internet cache folder. This is the same folder that is used by the Windows Internet API.</returns>
    public extern string InternetCache { [MethodImpl] get; }

    /// <summary>Gets the local application data folder.</summary>
    /// <returns>The string value of the path to the local app data folder.</returns>
    public extern string LocalAppData { [MethodImpl] get; }

    /// <summary>Gets the program data folder.</summary>
    /// <returns>The string value of the path to the program data folder.</returns>
    public extern string ProgramData { [MethodImpl] get; }

    /// <summary>Gets the roaming application data folder.</summary>
    /// <returns>The string value of the path to the roaming app data folder.</returns>
    public extern string RoamingAppData { [MethodImpl] get; }

    /// <summary>Gets the paths to a user's various app data folders. Use this method in multi-user apps.</summary>
    /// <param name="user">The user to retreive the paths for.</param>
    /// <returns>The app data paths associated with the user.</returns>
    [MethodImpl]
    public static extern AppDataPaths GetForUser(User user);

    /// <summary>Gets the paths to a user's various app data folders. Use this method in single user apps.</summary>
    /// <returns>The app data paths associated with the user.</returns>
    [MethodImpl]
    public static extern AppDataPaths GetDefault();
  }
}
