// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Provides access to the result of a request to grant a free entitlement.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GetEntitlementResult : IGetEntitlementResult
  {
    /// <summary>Indicates the result of a request to grant a free entitlement.</summary>
    /// <returns>A GetEntitlementStatus value that indicates the result of a request to grant a free entitlement.</returns>
    public extern GetEntitlementStatus Status { [MethodImpl] get; }
  }
}
