// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandServiceConnectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandServiceConnection))]
  [Guid(923713531, 11572, 17119, 135, 112, 7, 77, 15, 51, 70, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandServiceConnectionStatics
  {
    VoiceCommandServiceConnection FromAppServiceTriggerDetails(
      AppServiceTriggerDetails triggerDetails);
  }
}
