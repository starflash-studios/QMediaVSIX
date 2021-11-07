// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.QuantumSizeSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Defines values used for quantum size selection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum QuantumSizeSelectionMode
  {
    /// <summary>Use the system default value.</summary>
    SystemDefault,
    /// <summary>Use the value with the lowest latency.</summary>
    LowestLatency,
    /// <summary>Use the value closest to the one desired.</summary>
    ClosestToDesired,
  }
}
