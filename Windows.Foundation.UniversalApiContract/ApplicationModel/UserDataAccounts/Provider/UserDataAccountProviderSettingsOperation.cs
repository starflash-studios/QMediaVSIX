// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderSettingsOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Provides the data for an account settings operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataAccountProviderSettingsOperation : 
    IUserDataAccountProviderSettingsOperation,
    IUserDataAccountProviderOperation
  {
    /// <summary>Gets the user account ID for this settings operation.</summary>
    /// <returns>The user account ID for this settings operation.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Reports back to the calling app that the operation is complete.</summary>
    [MethodImpl]
    public extern void ReportCompleted();

    /// <summary>Gets the type of this account operation.</summary>
    /// <returns>The type of this account operation.</returns>
    public extern UserDataAccountProviderOperationKind Kind { [MethodImpl] get; }
  }
}
