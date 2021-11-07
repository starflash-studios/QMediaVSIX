// Decompiled with JetBrains decompiler
// Type: Windows.System.ProcessorArchitecture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the processor architecture supported by an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProcessorArchitecture
  {
    /// <summary>The x86 processor architecture.</summary>
    X86 = 0,
    /// <summary>The ARM processor architecture.</summary>
    Arm = 5,
    /// <summary>The x64 processor architecture.</summary>
    X64 = 9,
    /// <summary>A neutral processor architecture.</summary>
    Neutral = 11, // 0x0000000B
    /// <summary>The Arm64 processor architecture</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] Arm64 = 12, // 0x0000000C
    /// <summary>The Arm64 processor architecture emulating the X86 architecture</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] X86OnArm64 = 14, // 0x0000000E
    /// <summary>An unknown processor architecture.</summary>
    Unknown = 65535, // 0x0000FFFF
  }
}
