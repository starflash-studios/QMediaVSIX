// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines static methods and properties for accessing information about the device hardware and configuring information about the system, the mobile operator, and the active user account. These members are used in various Microsoft Store scenarios.</summary>
  [Static(typeof (IStoreConfigurationStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class StoreConfiguration
  {
    /// <summary>Determines whether apps can be pinned to the desktop on the current device.</summary>
    /// <returns>True if apps can be pinned to the desktop on the current device; otherwise, false. For example, this method returns false if the current device has no desktop.</returns>
    [MethodImpl]
    public static extern bool IsPinToDesktopSupported();

    /// <summary>Determines whether apps can be pinned to the taskbar on the current device.</summary>
    /// <returns>True if apps can be pinned to the taskbar on the current device; otherwise, false. For example, this method returns false if the current device has no taskbar.</returns>
    [MethodImpl]
    public static extern bool IsPinToTaskbarSupported();

    /// <summary>Determines whether apps can be pinned to the Start menu on the current device.</summary>
    /// <returns>True if apps can be pinned to the Start menu on the current device; otherwise, false. For example, this method returns false if the current device has no Start menu.</returns>
    [MethodImpl]
    public static extern bool IsPinToStartSupported();

    /// <summary>Pins the specified app to the desktop for the all users on the current device.</summary>
    /// <param name="appPackageFamilyName">The package family name of the app to pin to the desktop.</param>
    [MethodImpl]
    public static extern void PinToDesktop(string appPackageFamilyName);

    /// <summary>Pins the specified app to the desktop for the specified user on the current device.</summary>
    /// <param name="user">The user for which the app will be pinned to the desktop.</param>
    /// <param name="appPackageFamilyName">The package family name of the app to pin to the desktop.</param>
    [MethodImpl]
    public static extern void PinToDesktopForUser(User user, string appPackageFamilyName);

    /// <summary>Gets the Store user account ID for the current user who is signed in to the Store.</summary>
    /// <returns>The Store user account ID for the current user who is signed in to the Store.</returns>
    [MethodImpl]
    public static extern string GetStoreWebAccountId();

    /// <summary>Gets the Store user account ID for the specified user who is signed in to the Store.</summary>
    /// <param name="user">A Windows.System.User object that identifies the user for which you want to retrieve the Store user account ID.</param>
    /// <returns>The Store user account ID for the specified user.</returns>
    [MethodImpl]
    public static extern string GetStoreWebAccountIdForUser(User user);

    /// <summary>Sets the Store user account ID for the current Azure AD user who is signed in to the Store so that other apps can query against this ID.</summary>
    /// <param name="webAccountId">The Store user account ID (typically obtained from the WebAccount.Id property) to set for the Azure AD user who is currently signed in to the Store.</param>
    [MethodImpl]
    public static extern void SetEnterpriseStoreWebAccountId(string webAccountId);

    /// <summary>Sets the Store user account ID for the specified Azure AD user so that other apps can query against this ID.</summary>
    /// <param name="user">A Windows.System.User object that identifies the Azure AD user whose Store user account ID you want to set.</param>
    /// <param name="webAccountId">The Store user account ID (typically obtained from the WebAccount.Id property) to set for the specified Azure AD user.</param>
    [MethodImpl]
    public static extern void SetEnterpriseStoreWebAccountIdForUser(User user, string webAccountId);

    /// <summary>Gets the Store user account ID for the current Azure AD user who is signed in to the Store.</summary>
    /// <returns>The Store user account ID for the current Azure AD user who is signed in to the Store.</returns>
    [MethodImpl]
    public static extern string GetEnterpriseStoreWebAccountId();

    /// <summary>Gets the Store user account ID for the specified Azure AD user who is signed in to the Store.</summary>
    /// <param name="user">A Windows.System.User object that identifies the Azure AD user for which you want to retrieve the user account ID.</param>
    /// <returns>The Store user account ID for the specified user.</returns>
    [MethodImpl]
    public static extern string GetEnterpriseStoreWebAccountIdForUser(User user);

    /// <summary>Determines whether the Microsoft Store for Business is enabled for the current user.</summary>
    /// <returns>True if the Microsoft Store for Business is enabled for the current user; otherwise false.</returns>
    [MethodImpl]
    public static extern bool ShouldRestrictToEnterpriseStoreOnly();

    /// <summary>Determines whether the Microsoft Store for Business is enabled for the specified user.</summary>
    /// <param name="user">A Windows.System.User object that identifies the user for whom you want to determine whether the Microsoft Store for Business is enabled.</param>
    /// <returns>True if the Microsoft Store for Business is enabled for the specified user; otherwise false.</returns>
    [MethodImpl]
    public static extern bool ShouldRestrictToEnterpriseStoreOnlyForUser(User user);

    /// <summary>Determines whether the current user has a Microsoft Store account.</summary>
    /// <returns>True if the current user has a Microsoft Store account; otherwise false.</returns>
    [MethodImpl]
    public static extern bool HasStoreWebAccount();

    /// <summary>Determines whether the specified user has a Microsoft Store account.</summary>
    /// <param name="user">An object that identifies the user for which to query.</param>
    /// <returns>True if the specified userhas a Microsoft Store account; otherwise false.</returns>
    [MethodImpl]
    public static extern bool HasStoreWebAccountForUser(User user);

    /// <summary>Gets Microsoft Store log data for the current device.</summary>
    /// <param name="options">A value that specifies options for the log data request.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an IRandomAccessStreamReference object that contains the log data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStreamReference> GetStoreLogDataAsync(
      StoreLogOptions options);

    /// <summary>Sets the Store user account ID for the specified user so that other apps can query against this ID.</summary>
    /// <param name="user">A Windows.System.User object that identifies the user whose Store user account ID you want to set.</param>
    /// <param name="webAccountId">The Store user account ID (typically obtained from the WebAccount.Id property) to set for the specified user.</param>
    [MethodImpl]
    public static extern void SetStoreWebAccountIdForUser(User user, string webAccountId);

    /// <summary>Determines whether the specified user and user ID is also being used to sign in to the Microsoft Store on the device.</summary>
    /// <param name="user">An object that identifies the user for which to query.</param>
    /// <param name="webAccountId">The user ID (typically obtained from the WebAccount.Id property) to check.</param>
    /// <returns>True if the user account specified by *webAccountId* is the same account that is signed in to the Microsoft Store; otherwise false.</returns>
    [MethodImpl]
    public static extern bool IsStoreWebAccountIdForUser(User user, string webAccountId);

    /// <summary>Gets a value that indicates whether the Windows Store prompts the specified user before making a purchase.</summary>
    /// <param name="user">An object that identifies the user for which to query.</param>
    /// <returns>A **UInt32** value that indicates whether the Windows Store prompts the specified user before making a purchase. &lt;table&gt;</returns>
    [MethodImpl]
    public static extern IReference<uint> GetPurchasePromptingPolicyForUser(User user);

    [MethodImpl]
    public static extern void SetPurchasePromptingPolicyForUser(User user, IReference<uint> value);

    /// <summary>Gets or sets a value that indicates whether the Microsoft Store prompts the user before making a purchase.</summary>
    /// <returns>A **UInt32** value that indicates whether the Microsoft Store prompts the user before making a purchase. &lt;table&gt;</returns>
    public static extern IReference<uint> PurchasePromptingPolicy { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern void SetSystemConfiguration(
      string catalogHardwareManufacturerId,
      string catalogStoreContentModifierId,
      DateTime systemConfigurationExpiration,
      string catalogHardwareDescriptor);

    /// <summary>Configures mobile operator information for the device.</summary>
    /// <param name="mobileOperatorId">The mobile operator ID.</param>
    /// <param name="appDownloadLimitInMegabytes">The maximum app download size defined by the mobile operator, in MB.</param>
    /// <param name="updateDownloadLimitInMegabytes">The maximum OS update download size defined by the mobile operator, in MB.</param>
    [MethodImpl]
    public static extern void SetMobileOperatorConfiguration(
      string mobileOperatorId,
      uint appDownloadLimitInMegabytes,
      uint updateDownloadLimitInMegabytes);

    /// <summary>Sets the Store user account ID for the current user who is signed in to the Store so that other apps can query against this ID.</summary>
    /// <param name="webAccountId">The Store user account ID (typically obtained from the WebAccount.Id property) to set for the user who is currently signed in to the Store.</param>
    [MethodImpl]
    public static extern void SetStoreWebAccountId(string webAccountId);

    /// <summary>Determines whether the specified user ID is also being used to sign in to the Microsoft Store on the device.</summary>
    /// <param name="webAccountId">The user ID (typically obtained from the WebAccount.Id property) to check.</param>
    /// <returns>True if the user account specified by *webAccountId* is the same account that is signed in to the Microsoft Store; otherwise false.</returns>
    [MethodImpl]
    public static extern bool IsStoreWebAccountId(string webAccountId);

    /// <summary>Gets hardware manufacturer information for the current device.</summary>
    /// <returns>An object that provides information about the hardware manufacturer of the current device.</returns>
    public static extern StoreHardwareManufacturerInfo HardwareManufacturerInfo { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<StoreSystemFeature>> FilterUnsupportedSystemFeaturesAsync(
      IIterable<StoreSystemFeature> systemFeatures);
  }
}
