// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionLostEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information that identifies the reason for a lost session.</summary>
  [Activatable(typeof (IAllJoynSessionLostEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynSessionLostEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class AllJoynSessionLostEventArgs : IAllJoynSessionLostEventArgs
  {
    /// <summary>Generates an AllJoynSessionLostEventArgs object containing information that identifies the reason for the lost session.</summary>
    /// <param name="reason">The reason the session was lost.</param>
    [Deprecated("AllJoynSessionLostEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynSessionLostEventArgs(AllJoynSessionLostReason reason);

    /// <summary>Retrieves a value that indicates the reason for a lost session.</summary>
    /// <returns>The reason the session was lost. Possible values are defined by AllJoynSessionLostReason.</returns>
    public extern AllJoynSessionLostReason Reason { [Deprecated("AllJoynSessionLostEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
