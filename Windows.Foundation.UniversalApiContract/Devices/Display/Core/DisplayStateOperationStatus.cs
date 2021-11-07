// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayStateOperationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify the result of a DisplayState operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayStateOperationStatus
  {
    /// <summary>Indicates that the operation succeeded.</summary>
    Success,
    /// <summary>Indicates that the operation failed, but some system state was modified.</summary>
    PartialFailure,
    /// <summary>Indicates that the operation failed for an unknown reason.</summary>
    UnknownFailure,
    /// <summary>Indicates that the operation failed because target ownership has been lost.</summary>
    TargetOwnershipLost,
    /// <summary>Indicates that the operation failed because the system display state has changed since the relevant DisplayState object was created.</summary>
    SystemStateChanged,
    /// <summary>Indicates that an involved adapter cannot support the number of paths requested.</summary>
    TooManyPathsForAdapter,
    /// <summary>Indicates that the operation failed because one or more modes specified by a DisplayPath are not supported in the present configuration.</summary>
    ModesNotSupported,
    /// <summary>Indicates that the operation failed because the current session is currently in an unsupported remote desktop session that does not allow access to the display stack.</summary>
    RemoteSessionNotSupported,
  }
}
