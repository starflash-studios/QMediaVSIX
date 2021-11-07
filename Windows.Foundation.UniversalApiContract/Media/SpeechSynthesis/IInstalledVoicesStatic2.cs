// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.IInstalledVoicesStatic2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  [Guid(1680170798, 13709, 16472, 190, 154, 253, 63, 203, 66, 53, 48)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IInstalledVoicesStatic2
  {
    [RemoteAsync]
    IAsyncOperation<bool> TrySetDefaultVoiceAsync(VoiceInformation voice);
  }
}
