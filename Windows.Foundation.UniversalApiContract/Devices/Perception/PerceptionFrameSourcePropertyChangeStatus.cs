// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Indicates the status of a property change that an app requested of a frame source.</summary>
  /// <deprecated type="deprecate">PerceptionFrameSourcePropertyChangeStatus may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionFrameSourcePropertyChangeStatus may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public enum PerceptionFrameSourcePropertyChangeStatus
  {
    /// <summary>The status change is unknown.</summary>
    Unknown,
    /// <summary>The requested property change was accepted by the frame source.</summary>
    Accepted,
    /// <summary>The frame source property could not be changed because the app lost controller mode before the request was processed.</summary>
    LostControl,
    /// <summary>The requested property is not supported by the frame source.</summary>
    PropertyNotSupported,
    /// <summary>The requested property change was not accepted because the property is read-only.</summary>
    PropertyReadOnly,
    /// <summary>The requested property change was not accepted because the value is not in a valid range.</summary>
    ValueOutOfRange,
  }
}
