// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaCommandEnablingRule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies a rule for enabling a System Media Transport Controls command.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaCommandEnablingRule
  {
    /// <summary>The system dynamically determines whether the command is enabled.</summary>
    Auto,
    /// <summary>The command is always enabled.</summary>
    Always,
    /// <summary>The command is never enabled.</summary>
    Never,
  }
}
