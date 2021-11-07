// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  /// <summary>Provides access to data about an account operation.</summary>
  [Guid(2718608739, 34956, 19042, 163, 221, 52, 208, 122, 128, 43, 43)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IUserDataAccountProviderOperation
  {
    /// <summary>Gets the type of account operation, such as adding an account or updating settings.</summary>
    /// <returns>The type of account operation, such as adding an account or updating settings.</returns>
    UserDataAccountProviderOperationKind Kind { get; }
  }
}
