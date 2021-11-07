// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.AdvertisingManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  /// <summary>Provides a property that lets the caller retrieve the advertising ID.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAdvertisingManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAdvertisingManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public static class AdvertisingManager
  {
    /// <summary>Gets the advertising ID for the specified user.</summary>
    /// <param name="user">The user to get the advertising ID for.</param>
    /// <returns>An instance of AdvertisingManagerForUser that associates a user ID with their advertising ID.</returns>
    [MethodImpl]
    public static extern AdvertisingManagerForUser GetForUser(User user);

    /// <summary>Retrieves a unique ID used to provide more relevant advertising. If the advertising ID feature is turned off, no ID is retrieved.</summary>
    /// <returns>The advertising ID is represented as an alphanumeric string. When the advertising ID feature is turned off, this is an empty string.</returns>
    public static extern string AdvertisingId { [MethodImpl] get; }
  }
}
