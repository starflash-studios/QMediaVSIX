// Decompiled with JetBrains decompiler
// Type: Windows.System.KnownUserProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Contains basic information about a user.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IKnownUserPropertiesStatics2), 917504, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownUserPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class KnownUserProperties
  {
    public static extern string AgeEnforcementRegion { [MethodImpl] get; }

    /// <summary>Gets the user's display name.</summary>
    /// <returns>The user's display name.</returns>
    public static extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the user's first name.</summary>
    /// <returns>The user's first name.</returns>
    public static extern string FirstName { [MethodImpl] get; }

    /// <summary>Gets the user's last name.</summary>
    /// <returns>The user's last name.</returns>
    public static extern string LastName { [MethodImpl] get; }

    /// <summary>Gets the user's provider name.</summary>
    /// <returns>The user's provider name.</returns>
    public static extern string ProviderName { [MethodImpl] get; }

    /// <summary>Gets the user's account name.</summary>
    /// <returns>The user's account name.</returns>
    public static extern string AccountName { [MethodImpl] get; }

    /// <summary>Gets the user's guest host.</summary>
    /// <returns>The user's guest host.</returns>
    public static extern string GuestHost { [MethodImpl] get; }

    /// <summary>Gets the user's principal name.</summary>
    /// <returns>The user's principal name.</returns>
    public static extern string PrincipalName { [MethodImpl] get; }

    /// <summary>Gets the user's domain name.</summary>
    /// <returns>The user's domain name.</returns>
    public static extern string DomainName { [MethodImpl] get; }

    /// <summary>Gets the user's session initiation protocol Uri.</summary>
    /// <returns>The user's session initiation protocol Uri.</returns>
    public static extern string SessionInitiationProtocolUri { [MethodImpl] get; }
  }
}
