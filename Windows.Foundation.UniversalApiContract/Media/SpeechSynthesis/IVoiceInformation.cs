// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.IVoiceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [Guid(2972178084, 4753, 17924, 170, 156, 131, 19, 64, 131, 53, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VoiceInformation))]
  internal interface IVoiceInformation
  {
    string DisplayName { get; }

    string Id { get; }

    string Language { get; }

    string Description { get; }

    VoiceGender Gender { get; }
  }
}
