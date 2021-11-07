// Decompiled with JetBrains decompiler
// Type: Windows.System.User
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System
{
  /// <summary>Represents a user.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IUserStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUserStatics2), 720896, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class User : IUser, IUser2
  {
    /// <summary>Gets the user's non-roamable id.</summary>
    /// <returns>The user's non-roamable Id.</returns>
    public extern string NonRoamableId { [MethodImpl] get; }

    /// <summary>Gets the authentication status of the user.</summary>
    /// <returns>The authentication status of the user.</returns>
    public extern UserAuthenticationStatus AuthenticationStatus { [MethodImpl] get; }

    /// <summary>Gets the user type.</summary>
    /// <returns>The user type.</returns>
    public extern UserType Type { [MethodImpl] get; }

    /// <summary>Gets a property for the user. Use the KnownUserProperties class to obtain property names.</summary>
    /// <param name="value">The property to get.</param>
    /// <returns>When this method completes, it returns the requested property. If the property is missing or unavailable, an empty string is returned.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<object> GetPropertyAsync(string value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IPropertySet> GetPropertiesAsync(
      IVectorView<string> values);

    /// <summary>Gets a user's picture asynchronously.</summary>
    /// <param name="desiredSize">The desired size of the user's picture to return.</param>
    /// <returns>When this method completes, it returns the user's picture.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamReference> GetPictureAsync(
      UserPictureSize desiredSize);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserAgeConsentResult> CheckUserAgeConsentGroupAsync(
      UserAgeConsentGroup consentGroup);

    [MethodImpl]
    public static extern User GetDefault();

    /// <summary>Creates a UserWatcher which enumerates users and raises events when the collection of users changes or when a user’s authentication state changes.</summary>
    /// <returns>A UserWatcher which enumerates users and raises events when the collection of users changes.</returns>
    [MethodImpl]
    public static extern UserWatcher CreateWatcher();

    /// <summary>Finds all users asynchronously.</summary>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of Users.</returns>
    [Overload("FindAllAsync")]
    [DefaultOverload]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync();

    /// <summary>Finds all users of a given type asynchronously.</summary>
    /// <param name="type">The type of users to find.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of Users.</returns>
    [Deprecated("FindAllAsyncByType is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("FindAllAsyncByType")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type);

    /// <summary>Finds all users of a given type and authentication status asynchronously.</summary>
    /// <param name="type">The type of users to find.</param>
    /// <param name="status">The authentication status of users to find.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of Users.</returns>
    [RemoteAsync]
    [Overload("FindAllAsyncByTypeAndStatus")]
    [Deprecated("FindAllAsyncByTypeAndStatus is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type,
      UserAuthenticationStatus status);

    /// <summary>Gets a user with a given Id.</summary>
    /// <param name="nonRoamableId">The Id of the user to get.</param>
    /// <returns>The user with the given Id.</returns>
    [MethodImpl]
    public static extern User GetFromId(string nonRoamableId);
  }
}
