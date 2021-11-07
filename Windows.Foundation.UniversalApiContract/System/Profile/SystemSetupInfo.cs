// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemSetupInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides a property and an event that describe the current stage in the lifecycle of the Out-of-Box Experience (OOBE).</summary>
  [Static(typeof (ISystemSetupInfoStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class SystemSetupInfo
  {
    /// <summary>Gets a value representing the current stage in the lifecycle of the Out-of-Box Experience (OOBE).</summary>
    /// <returns>A SystemOutOfBoxExperienceState value describing the current stage in the lifecycle of the Out-of-Box Experience (OOBE).</returns>
    public static extern SystemOutOfBoxExperienceState OutOfBoxExperienceState { [MethodImpl] get; }

    /// <summary>Raised when the current stage in the lifecycle of the Out-of-Box Experience (OOBE) changes.</summary>
    public static extern event EventHandler<object> OutOfBoxExperienceStateChanged;
  }
}
