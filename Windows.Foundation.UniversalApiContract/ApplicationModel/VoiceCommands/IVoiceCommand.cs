// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommand))]
  [Guid(2473546355, 60546, 17062, 165, 92, 210, 215, 158, 198, 249, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommand
  {
    string CommandName { get; }

    IMapView<string, IVectorView<string>> Properties { get; }

    SpeechRecognitionResult SpeechRecognitionResult { get; }
  }
}
