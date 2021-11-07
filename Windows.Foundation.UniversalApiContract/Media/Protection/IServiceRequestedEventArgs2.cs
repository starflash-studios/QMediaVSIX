// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IServiceRequestedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Protection
{
  [Guid(1430022614, 64254, 16680, 141, 250, 19, 14, 57, 138, 19, 167)]
  [ExclusiveTo(typeof (ServiceRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IServiceRequestedEventArgs2
  {
    MediaPlaybackItem MediaPlaybackItem { get; }
  }
}
