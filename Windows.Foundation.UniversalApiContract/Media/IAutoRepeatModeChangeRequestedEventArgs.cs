// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAutoRepeatModeChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (AutoRepeatModeChangeRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3927146234, 55378, 17294, 136, 43, 201, 144, 16, 154, 120, 244)]
  internal interface IAutoRepeatModeChangeRequestedEventArgs
  {
    MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode { get; }
  }
}
