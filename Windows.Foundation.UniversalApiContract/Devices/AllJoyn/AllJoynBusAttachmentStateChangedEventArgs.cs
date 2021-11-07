// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about state and status changes to an AllJoyn bus connection managed by an AllJoynBusAttachment object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynBusAttachmentStateChangedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynBusAttachmentStateChangedEventArgs : 
    IAllJoynBusAttachmentStateChangedEventArgs
  {
    /// <summary>Indicates the current state of a connection to an AllJoyn bus.</summary>
    /// <returns>The current connection state.</returns>
    public extern AllJoynBusAttachmentState State { [Deprecated("AllJoynBusAttachmentStateChangedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Contains a status code that provides status information for AllJoynBusAttachment change events. Properties used in the generation of possible values are defined by AllJoynStatus.</summary>
    /// <returns>The AllJoyn status code associated with the event.</returns>
    public extern int Status { [Deprecated("AllJoynBusAttachmentStateChangedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
