// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayPathStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify the last status of the path in the system, captured when the DisplayState was last created or applied.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayPathStatus
  {
    /// <summary>Used for newly created paths that have not been applied.</summary>
    Unknown,
    /// <summary>Indicates that the path has been successfully applied, and was currently active when the DisplayState was last created or applied.</summary>
    Succeeded,
    /// <summary>Indicates that the last apply operation was completed successfully, but the driver has indicated that it is still applying the path to the hardware asynchronously.</summary>
    Pending,
    /// <summary>Indicates that a path failed synchronously during a TryApply or TryFunctionalize call.</summary>
    Failed,
    /// <summary>Indicates that the display hardware has asynchronously failed the path, either due to changing bandwidth allocations, or due to driver errors during another mode change. This path should be re-evaluated and re-applied by the owner.</summary>
    FailedAsync,
    /// <summary>Indicates that the path is likely still valid in hardware, but requires applying a mode again in order to reset pending software state. A path in this state typically shows a black screen on the output.</summary>
    InvalidatedAsync,
  }
}
