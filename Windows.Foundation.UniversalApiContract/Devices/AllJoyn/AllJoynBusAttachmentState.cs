// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusAttachmentState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines values used to indicate the state of a connection with an AllJoyn bus that is managed by an AllJoynBusAttachment object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynBusAttachmentState has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public enum AllJoynBusAttachmentState
  {
    /// <summary>Disconnected from the bus.</summary>
    Disconnected,
    /// <summary>Connecting to the bus.</summary>
    Connecting,
    /// <summary>Currently connected to the bus.</summary>
    Connected,
    /// <summary>Currently disconnecting from the bus.</summary>
    Disconnecting,
  }
}
