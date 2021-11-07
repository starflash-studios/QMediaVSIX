// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Provides access to the current app's license metadata.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LicenseInformation : ILicenseInformation
  {
    /// <summary>Gets the associative list of licenses for in-app products that the user is currently entitled to.</summary>
    /// <returns>The associative list of feature licenses.</returns>
    public extern IMapView<string, ProductLicense> ProductLicenses { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license is active.</summary>
    /// <returns>Returns true if the license is active, and otherwise false. Returns false if the license is missing, expired, or revoked. See the remarks in IsTrial for more info.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license is a trial license.</summary>
    /// <returns>Returns true if the license is a trial license, and otherwise false.</returns>
    public extern bool IsTrial { [MethodImpl] get; }

    /// <summary>Gets the license expiration date and time relative to the system clock.</summary>
    /// <returns>The date and time that the app's trial license will expire.</returns>
    public extern DateTime ExpirationDate { [MethodImpl] get; }

    /// <summary>Raises a notification event when the status of the app's license changes.</summary>
    public extern event LicenseChangedEventHandler LicenseChanged;
  }
}
