// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Defines the possible results of a request to grant a free entitlement by using the GetFreeDeviceEntitlementAsync, GetFreeUserEntitlementAsync, or GetFreeUserEntitlementForUserAsync methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GetEntitlementStatus
  {
    /// <summary>The request succeeded.</summary>
    Succeeded,
    /// <summary>The request was unsuccessful because the specified user does not have a Microsoft account that is associated with the Store on the current device.</summary>
    NoStoreAccount,
    /// <summary>The request was unsuccessful because of a network connection error.</summary>
    NetworkError,
    /// <summary>The request was unsuccessful because of a server error.</summary>
    ServerError,
  }
}
