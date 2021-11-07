// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmSessionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>This is used as an entry point for creating new sessions, viewing old sessions, or cleanup.</summary>
  [Static(typeof (IMdmSessionManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public static class MdmSessionManager
  {
    /// <summary>Gets all MDM session IDs for the current enterprise account.</summary>
    /// <returns>An IVectorView containing the session IDs.</returns>
    public static extern IVectorView<string> SessionIds { [MethodImpl] get; }

    /// <summary>Attempts to start an MDM session for the current enterprise account.</summary>
    /// <returns>The MdmSession information of the created session.</returns>
    [MethodImpl]
    public static extern MdmSession TryCreateSession();

    /// <summary>Deletes past session information.</summary>
    /// <param name="sessionId">The string value of the session ID.</param>
    [MethodImpl]
    public static extern void DeleteSessionById(string sessionId);

    /// <summary>Gets the MDM session's information given the session's ID.</summary>
    /// <param name="sessionId">The string value of the MDM session ID.</param>
    /// <returns>The MdmSession corresponding to the provided session ID.</returns>
    [MethodImpl]
    public static extern MdmSession GetSessionById(string sessionId);
  }
}
