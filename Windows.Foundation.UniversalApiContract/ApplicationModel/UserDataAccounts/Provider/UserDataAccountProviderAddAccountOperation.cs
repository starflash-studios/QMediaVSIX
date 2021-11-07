// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderAddAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Provides the data for adding a new user account.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserDataAccountProviderAddAccountOperation : 
    IUserDataAccountProviderAddAccountOperation,
    IUserDataAccountProviderOperation
  {
    /// <summary>Gets the types of content supported by the user account, such as email, contacts, and appointments.</summary>
    /// <returns>The types of content supported by the user account, such as email, contacts, and appointments.</returns>
    public extern UserDataAccountContentKinds ContentKinds { [MethodImpl] get; }

    /// <summary>Gets a list of UserDataAccountPartnerAccountInfo objects for this operation.</summary>
    /// <returns>A list of UserDataAccountPartnerAccountInfo objects for this operation.</returns>
    public extern IVectorView<UserDataAccountPartnerAccountInfo> PartnerAccountInfos { [MethodImpl] get; }

    /// <summary>Reports back to the calling app that the operation is complete.</summary>
    /// <param name="userDataAccountId">The identifier for the user account upon which the operation completed.</param>
    [MethodImpl]
    public extern void ReportCompleted(string userDataAccountId);

    /// <summary>Gets the type of this account operation.</summary>
    /// <returns>The type of this account operation.</returns>
    public extern UserDataAccountProviderOperationKind Kind { [MethodImpl] get; }
  }
}
