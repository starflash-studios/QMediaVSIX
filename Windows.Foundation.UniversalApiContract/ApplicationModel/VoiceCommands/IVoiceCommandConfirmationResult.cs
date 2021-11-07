// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandConfirmationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2686605630, 33313, 17702, 176, 131, 132, 9, 114, 38, 34, 71)]
  [ExclusiveTo(typeof (VoiceCommandConfirmationResult))]
  internal interface IVoiceCommandConfirmationResult
  {
    bool Confirmed { get; }
  }
}
