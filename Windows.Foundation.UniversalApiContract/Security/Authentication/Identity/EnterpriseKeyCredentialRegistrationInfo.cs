// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  /// <summary>Contains information about an enterprise key credential registration.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EnterpriseKeyCredentialRegistrationInfo : 
    IEnterpriseKeyCredentialRegistrationInfo
  {
    /// <summary>Gets the tenant Id.</summary>
    /// <returns>The tenant Id.</returns>
    public extern string TenantId { [MethodImpl] get; }

    /// <summary>Gets the tenant name.</summary>
    /// <returns>The tenant name.</returns>
    public extern string TenantName { [MethodImpl] get; }

    /// <summary>Gets the subject.</summary>
    /// <returns>The subject.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the key Id.</summary>
    /// <returns>The key Id.</returns>
    public extern string KeyId { [MethodImpl] get; }

    /// <summary>Gets the key name.</summary>
    /// <returns>The key name.</returns>
    public extern string KeyName { [MethodImpl] get; }
  }
}
