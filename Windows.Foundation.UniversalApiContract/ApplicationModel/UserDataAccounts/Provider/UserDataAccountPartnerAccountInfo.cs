// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountPartnerAccountInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Represents data about an account for partner service.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserDataAccountPartnerAccountInfo : IUserDataAccountPartnerAccountInfo
  {
    /// <summary>Gets the human readable display name for this user account.</summary>
    /// <returns>The human readable display name for this user account.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the priority for the service that uses this kind of user account.</summary>
    /// <returns>The priority for the service that uses this kind of user account.</returns>
    public extern uint Priority { [MethodImpl] get; }

    /// <summary>Gets the type of this user account.</summary>
    /// <returns>The type of this user account.</returns>
    public extern UserDataAccountProviderPartnerAccountKind AccountKind { [MethodImpl] get; }
  }
}
