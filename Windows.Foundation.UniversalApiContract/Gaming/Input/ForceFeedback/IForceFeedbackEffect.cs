// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IForceFeedbackEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>Describes a force feedback effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2709502476, 10980, 18626, 128, 99, 234, 189, 7, 119, 203, 137)]
  public interface IForceFeedbackEffect
  {
    /// <summary>Specifies the percentage by which to reduce the force of the effect.</summary>
    /// <returns>Specifies the percentage by which to reduce the force of the effect.</returns>
    double Gain { get; set; }

    /// <summary>The state of the effect.</summary>
    /// <returns>The state of the effect.</returns>
    ForceFeedbackEffectState State { get; }

    /// <summary>Starts the effect.</summary>
    void Start();

    /// <summary>Stops the effect.</summary>
    void Stop();
  }
}
