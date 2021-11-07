// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayManagerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify the result of a DisplayManager operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayManagerResult
  {
    /// <summary>Indicates that the operation succeeded.</summary>
    Success,
    /// <summary>Indicates that the operation failed for an unknown reason.</summary>
    UnknownFailure,
    /// <summary>Indicates that the operation failed becaused a specified target could not be acquired, either due to another component currently owning it, or due to target ownership restrictions.</summary>
    TargetAccessDenied,
    /// <summary>Indicates that the operation failed because a specified target is stale and should be re-enumerated.</summary>
    TargetStale,
    /// <summary>Indicates that the operation failed because the current session is currently in an unsupported remote desktop session that does not allow access to the display stack.</summary>
    RemoteSessionNotSupported,
  }
}
