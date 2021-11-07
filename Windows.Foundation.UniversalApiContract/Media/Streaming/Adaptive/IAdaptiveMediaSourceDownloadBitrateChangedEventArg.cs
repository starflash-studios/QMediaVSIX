// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadBitrateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadBitrateChangedEventArgs))]
  [Guid(1728842308, 57422, 20223, 129, 106, 23, 57, 159, 120, 244, 186)]
  internal interface IAdaptiveMediaSourceDownloadBitrateChangedEventArgs
  {
    uint OldValue { get; }

    uint NewValue { get; }
  }
}
