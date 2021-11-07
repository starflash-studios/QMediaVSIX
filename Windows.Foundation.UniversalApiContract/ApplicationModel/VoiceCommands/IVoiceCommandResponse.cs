// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(42251022, 35387, 19652, 166, 161, 202, 213, 190, 39, 22, 181)]
  [ExclusiveTo(typeof (VoiceCommandResponse))]
  internal interface IVoiceCommandResponse
  {
    VoiceCommandUserMessage Message { get; set; }

    VoiceCommandUserMessage RepeatMessage { get; set; }

    string AppLaunchArgument { get; set; }

    IVector<VoiceCommandContentTile> VoiceCommandContentTiles { get; }
  }
}
