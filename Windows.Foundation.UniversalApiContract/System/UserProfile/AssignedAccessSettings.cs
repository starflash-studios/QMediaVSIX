// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.AssignedAccessSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  /// <summary>Provides properties and methods to access the user's assigned access settings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAssignedAccessSettingsStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  public sealed class AssignedAccessSettings : IAssignedAccessSettings
  {
    /// <summary>Gets a value that indicates whether the user has configured _Assigned Access_ in the Windows settings.</summary>
    /// <returns>**true** if assigned access is configured; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the kiosk account is configured as a single-app kiosk.</summary>
    /// <returns>**true** if the kiosk account is configured as a single-app kiosk.; otherwise, **false**.</returns>
    public extern bool IsSingleAppKioskMode { [MethodImpl] get; }

    /// <summary>Gets the User associated with this instance of assigned access settings.</summary>
    /// <returns>The user associated with this instance of assigned access settings.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Retrieves the default assigned access settings.</summary>
    /// <returns>A settings object that contains the user's current assigned access settings.</returns>
    [MethodImpl]
    public static extern AssignedAccessSettings GetDefault();

    /// <summary>Retrieves the assigned access settings for the specified user.</summary>
    /// <param name="user">The user to get settings for.</param>
    /// <returns>A settings object that contains the user's current assigned access settings.</returns>
    [MethodImpl]
    public static extern AssignedAccessSettings GetForUser(User user);
  }
}
