// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionLostReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines values used by AllJoynSessionLostEventArgs to indicate the reason for a lost session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynSessionLostReason has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public enum AllJoynSessionLostReason
  {
    /// <summary>No reason indicated.</summary>
    None,
    /// <summary>The Producer left the session.</summary>
    ProducerLeftSession,
    /// <summary>The Producer closed the session unexpectedly.</summary>
    ProducerClosedAbruptly,
    /// <summary>The Consumer was removed from the session by the Producer.</summary>
    RemovedByProducer,
    /// <summary>The connection supporting the session timed out.</summary>
    LinkTimeout,
    /// <summary>The session was lost due to any other reason.</summary>
    Other,
  }
}
