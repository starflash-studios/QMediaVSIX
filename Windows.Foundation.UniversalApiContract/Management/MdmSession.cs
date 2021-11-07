// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>Provides functionality to start an MDM session with the server.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MdmSession : IMdmSession
  {
    /// <summary>A vector list of all MdmAlerts for the current session.</summary>
    /// <returns>A vector list of MdmAlerts.</returns>
    public extern IVectorView<MdmAlert> Alerts { [MethodImpl] get; }

    /// <summary>The extended error code for an MDM session.</summary>
    /// <returns>HRESULT value of the error.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>The ID for the MDM session.</summary>
    /// <returns>The string value of the session ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the state of an MDM session.</summary>
    /// <returns>An MdmSessionState enumeration value for the state of the session.</returns>
    public extern MdmSessionState State { [MethodImpl] get; }

    /// <summary>Allows the caller to re-open an existing MDM session.</summary>
    /// <returns>Results of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AttachAsync();

    /// <summary>Deletes the MDM session.</summary>
    [MethodImpl]
    public extern void Delete();

    /// <summary>Start an MDM session with a constant alerts.</summary>
    /// <returns>Results of the operation.</returns>
    [RemoteAsync]
    [Overload("StartAsync")]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [Overload("StartWithAlertsAsync")]
    [MethodImpl]
    public extern IAsyncAction StartAsync(IIterable<MdmAlert> alerts);
  }
}
