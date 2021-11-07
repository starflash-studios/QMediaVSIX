// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IUserDataAccountProviderActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.UserDataAccounts.Provider;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to manage user accounts.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(466220835, 36593, 19025, 166, 58, 254, 113, 30, 234, 182, 7)]
  public interface IUserDataAccountProviderActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the user account management operation.</summary>
    /// <returns>The user account management operation.</returns>
    IUserDataAccountProviderOperation Operation { get; }
  }
}
