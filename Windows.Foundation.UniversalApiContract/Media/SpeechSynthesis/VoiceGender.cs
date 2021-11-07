// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.VoiceGender
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  /// <summary>Specifies the gender preferences available for speech synthesis (if supported by the specified speech synthesis engine).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VoiceGender
  {
    /// <summary>Male</summary>
    Male,
    /// <summary>Female</summary>
    Female,
  }
}
