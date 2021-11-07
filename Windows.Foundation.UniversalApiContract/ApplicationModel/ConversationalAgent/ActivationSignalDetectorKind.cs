// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the supported ActivationSignalDetector types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum ActivationSignalDetectorKind
  {
    /// <summary>Audio input has matched a specified pattern (for example, a keyword or "bark detector").</summary>
    AudioPattern,
    /// <summary>Audio input has hit a signal threshold (for example, voice activity detection).</summary>
    AudioImpulse,
    /// <summary>Activation signal detected from a hardware device such as a keyboard or bluetooth headset.</summary>
    HardwareEvent,
  }
}
