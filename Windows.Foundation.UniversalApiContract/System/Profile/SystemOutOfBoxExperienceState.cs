// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemOutOfBoxExperienceState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Defines constants that specify the current stage in the lifecycle of the Out-of-Box Experience (OOBE).</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum SystemOutOfBoxExperienceState
  {
    /// <summary>Indicates that the OOBE has not yet started on this device.</summary>
    NotStarted,
    /// <summary>Indicates that the OOBE has started and is in progress on this device.</summary>
    InProgress,
    /// <summary>Indicates that the OOBE has completed on this device. This is the value reported for devices that have no OOBE.</summary>
    Completed,
  }
}
