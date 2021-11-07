// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.EnterpriseKeyCredentialRegistrationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  /// <summary>Provides access to information about enterprise key credential registrations.</summary>
  [Static(typeof (IEnterpriseKeyCredentialRegistrationManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EnterpriseKeyCredentialRegistrationManager : 
    IEnterpriseKeyCredentialRegistrationManager
  {
    /// <summary>Gets the enterprise key credential registrations.</summary>
    /// <returns>When this method completes, it returns the enterprise key credential registrations.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync();

    /// <summary>Gets the current enterprise key credential registration manager.</summary>
    /// <returns>The current enterprise key credential registration manager.</returns>
    public static extern EnterpriseKeyCredentialRegistrationManager Current { [MethodImpl] get; }
  }
}
