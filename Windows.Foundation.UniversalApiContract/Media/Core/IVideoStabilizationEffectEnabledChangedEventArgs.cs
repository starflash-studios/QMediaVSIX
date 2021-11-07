// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStabilizationEffectEnabledChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoStabilizationEffectEnabledChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(410976040, 26555, 18195, 185, 0, 65, 104, 218, 22, 69, 41)]
  internal interface IVideoStabilizationEffectEnabledChangedEventArgs
  {
    VideoStabilizationEffectEnabledChangedReason Reason { get; }
  }
}
