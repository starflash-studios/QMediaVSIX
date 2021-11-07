// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandServiceConnection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3633626015, 8666, 17572, 152, 162, 251, 19, 25, 32, 169, 204)]
  internal interface IVoiceCommandServiceConnection
  {
    [RemoteAsync]
    IAsyncOperation<VoiceCommand> GetVoiceCommandAsync();

    [RemoteAsync]
    IAsyncOperation<VoiceCommandConfirmationResult> RequestConfirmationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncOperation<VoiceCommandDisambiguationResult> RequestDisambiguationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportProgressAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportSuccessAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportFailureAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction RequestAppLaunchAsync(VoiceCommandResponse response);

    Language Language { get; }

    event TypedEventHandler<VoiceCommandServiceConnection, VoiceCommandCompletedEventArgs> VoiceCommandCompleted;
  }
}
