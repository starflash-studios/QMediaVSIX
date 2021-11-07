// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityChangeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the permission levels granted by a user to each ActivationSignalDetectionConfiguration of an ActivationSignalDetector.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum DetectionConfigurationAvailabilityChangeKind
  {
    /// <summary>Indicates that a configuration permission to access necessary system resources, such as signal model files, has changed.</summary>
    SystemResourceAccess,
    /// <summary>Indicates that a configuration permission has changed.</summary>
    Permission,
    /// <summary>Indicates that a configuration permission used above the lock screen has changed.</summary>
    LockScreenPermission,
  }
}
