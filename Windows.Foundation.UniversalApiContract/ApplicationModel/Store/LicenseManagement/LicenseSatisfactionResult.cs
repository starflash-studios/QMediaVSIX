// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  /// <summary>Provides license entitlement information that is returned by the GetSatisfactionInfosAsync method for the specified products.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class LicenseSatisfactionResult : ILicenseSatisfactionResult
  {
    /// <summary>Provides access to entitlement info that is returned by the GetSatisfactionInfosAsync method.</summary>
    /// <returns>A map of key and value pairs that represent entitlement info for the specified products. In each pair, the key is a content ID that you passed to GetSatisfactionInfosAsync, and the value is a LicenseSatisfactionInfo object that provides entitlement info for the corresponding product.</returns>
    public extern IMapView<string, LicenseSatisfactionInfo> LicenseSatisfactionInfos { [MethodImpl] get; }

    /// <summary>Contains the error code that was returned by GetSatisfactionInfosAsync.</summary>
    /// <returns>The error code that was returned by GetSatisfactionInfosAsync.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
