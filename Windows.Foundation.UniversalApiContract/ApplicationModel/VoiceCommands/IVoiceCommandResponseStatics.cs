// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandResponseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(691206163, 3387, 18930, 150, 221, 98, 80, 25, 189, 59, 93)]
  [ExclusiveTo(typeof (VoiceCommandResponse))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandResponseStatics
  {
    uint MaxSupportedVoiceCommandContentTiles { get; }

    [Overload("CreateResponse")]
    VoiceCommandResponse CreateResponse(VoiceCommandUserMessage userMessage);

    [Overload("CreateResponseWithTiles")]
    VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage message,
      IIterable<VoiceCommandContentTile> contentTiles);

    [Overload("CreateResponseForPrompt")]
    VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage);

    [Overload("CreateResponseForPromptWithTiles")]
    VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage,
      IIterable<VoiceCommandContentTile> contentTiles);
  }
}
