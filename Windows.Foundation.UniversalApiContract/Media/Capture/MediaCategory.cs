// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Defines values for types of media categories.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCategory
  {
    /// <summary>Media category is other.</summary>
    Other,
    /// <summary>Media is intended for real-time communications.</summary>
    Communications,
    /// <summary>General media.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Media,
    /// <summary>Media is game chat.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GameChat,
    /// <summary>Media is speech.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Speech,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] FarFieldSpeech,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] UniformSpeech,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] VoiceTyping,
  }
}
