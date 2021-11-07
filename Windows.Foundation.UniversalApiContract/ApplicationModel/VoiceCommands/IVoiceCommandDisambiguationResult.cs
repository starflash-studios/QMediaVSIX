// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandDisambiguationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3972435198, 51628, 17887, 168, 234, 254, 234, 8, 239, 156, 94)]
  [ExclusiveTo(typeof (VoiceCommandDisambiguationResult))]
  internal interface IVoiceCommandDisambiguationResult
  {
    VoiceCommandContentTile SelectedItem { get; }
  }
}
