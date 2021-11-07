// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateMediaSourceAudioInputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1185306787, 21440, 19801, 158, 81, 204, 29, 16, 68, 164, 196)]
  [ExclusiveTo(typeof (CreateMediaSourceAudioInputNodeResult))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ICreateMediaSourceAudioInputNodeResult
  {
    MediaSourceAudioInputNodeCreationStatus Status { get; }

    MediaSourceAudioInputNode Node { get; }
  }
}
