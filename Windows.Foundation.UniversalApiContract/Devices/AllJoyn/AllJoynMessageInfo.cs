// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynMessageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Exposes information about the sender of a message being processed.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAllJoynMessageInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynMessageInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public sealed class AllJoynMessageInfo : IAllJoynMessageInfo
  {
    /// <summary>Generates an AllJoynMessageInfo object that contains the unique name of the sender that sent the message being processed.</summary>
    /// <param name="senderUniqueName">The unique name of the sender.</param>
    [Deprecated("AllJoynMessageInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynMessageInfo(string senderUniqueName);

    /// <summary>The unique bus name of the message sender.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string SenderUniqueName { [Deprecated("AllJoynMessageInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
