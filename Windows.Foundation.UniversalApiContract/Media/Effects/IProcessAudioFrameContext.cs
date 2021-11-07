// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IProcessAudioFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessAudioFrameContext))]
  [Guid(1289300294, 4642, 18983, 165, 134, 251, 62, 32, 39, 50, 85)]
  internal interface IProcessAudioFrameContext
  {
    AudioFrame InputFrame { get; }

    AudioFrame OutputFrame { get; }
  }
}
