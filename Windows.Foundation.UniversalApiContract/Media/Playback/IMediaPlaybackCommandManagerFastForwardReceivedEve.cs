// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerFastForwardReceivedEventArgs))]
  [Guid(821060825, 46225, 19722, 188, 33, 48, 152, 189, 19, 50, 233)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
