// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.MediaMemoryTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Specifies the types of memory that can be used for a media operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaMemoryTypes
  {
    /// <summary>GPU memory.</summary>
    Gpu,
    /// <summary>CPU memory.</summary>
    Cpu,
    /// <summary>Both GPU and CPU memory.</summary>
    GpuAndCpu,
  }
}
