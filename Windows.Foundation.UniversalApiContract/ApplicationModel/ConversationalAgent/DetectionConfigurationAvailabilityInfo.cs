// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Provides availability details for the ActivationSignalDetector.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class DetectionConfigurationAvailabilityInfo : 
    IDetectionConfigurationAvailabilityInfo,
    IDetectionConfigurationAvailabilityInfo2
  {
    /// <summary>Gets whether the ActivationSignalDetector is enabled.</summary>
    /// <returns>True, if enabled. Otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets whether the ActivationSignalDetector can access system resources.</summary>
    /// <returns>True, if enabled. Otherwise, false.</returns>
    public extern bool HasSystemResourceAccess { [MethodImpl] get; }

    /// <summary>Gets whether the ActivationSignalDetector has user permission to listen for activation keywords.</summary>
    /// <returns>True, if permission granted. Otherwise, false.</returns>
    public extern bool HasPermission { [MethodImpl] get; }

    /// <summary>Gets whether the ActivationSignalDetector has user permission to operate above the lock screen.</summary>
    /// <returns>True, if permission granted. Otherwise, false.</returns>
    public extern bool HasLockScreenPermission { [MethodImpl] get; }

    public extern IVectorView<SignalDetectorResourceKind> UnavailableSystemResources { [MethodImpl] get; }
  }
}
