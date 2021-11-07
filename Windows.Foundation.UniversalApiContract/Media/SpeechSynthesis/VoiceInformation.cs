// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.VoiceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  /// <summary>Provides info about an installed speech synthesis engine (voice).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceInformation : IVoiceInformation
  {
    /// <summary>Gets the display name associated with the speech synthesis engine (voice).</summary>
    /// <returns>The display name of the voice.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the unique ID of the speech synthesis engine (voice).</summary>
    /// <returns>The unique ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the normalized BCP-47 language tag of the speech synthesis engine (voice).</summary>
    /// <returns>The normalized BCP-47 language tag.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets the description of the speech synthesis engine (voice).</summary>
    /// <returns>The description, based on a combination of DisplayName and Language. For example, Microsoft David - English (United States).</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the gender setting of the speech synthesis engine (voice).</summary>
    /// <returns>The gender of the voice.</returns>
    public extern VoiceGender Gender { [MethodImpl] get; }
  }
}
