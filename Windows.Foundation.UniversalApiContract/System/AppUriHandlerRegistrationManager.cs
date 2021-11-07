// Decompiled with JetBrains decompiler
// Type: Windows.System.AppUriHandlerRegistrationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Retrieves AppUriHandlerRegistrations for the calling package. This can be used to access AppUriHandler registrations.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IAppUriHandlerRegistrationManagerStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppUriHandlerRegistrationManagerStatics2), 851968, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppUriHandlerRegistrationManager : 
    IAppUriHandlerRegistrationManager,
    IAppUriHandlerRegistrationManager2
  {
    /// <summary>The user context registrations will occur for.</summary>
    /// <returns>The user context registrations will occur for.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Attempts to retrieve a registration object for the windows.AppUriHandler extension present in the caller's AppxManifest with the given name.</summary>
    /// <param name="name">Name corresponding to an entry in the caller's AppxManfiest.</param>
    /// <returns>AppUriHandlerRegistration object representing the AppxManifest extension registration. This can be used to update dynamic registrations.</returns>
    [MethodImpl]
    public extern AppUriHandlerRegistration TryGetRegistration(string name);

    public extern string PackageFamilyName { [MethodImpl] get; }

    [MethodImpl]
    public static extern AppUriHandlerRegistrationManager GetForPackage(
      string packageFamilyName);

    [MethodImpl]
    public static extern AppUriHandlerRegistrationManager GetForPackageForUser(
      string packageFamilyName,
      User user);

    /// <summary>Creates an AppUriHandlerRegistrationManager for the calling app for the current user.</summary>
    /// <returns>An AppUriHandlerRegistrationManager which can be used to access AppUriHandlerRegistrations.</returns>
    [MethodImpl]
    public static extern AppUriHandlerRegistrationManager GetDefault();

    /// <summary>Creates an AppUriHandlerRegistrationManager for the calling app for the requested user context.</summary>
    /// <param name="user">User context to perform operations for.</param>
    /// <returns>An AppUriHandlerRegistrationManager which can be used to access AppUriHandlerRegistrations.</returns>
    [MethodImpl]
    public static extern AppUriHandlerRegistrationManager GetForUser(
      User user);
  }
}
