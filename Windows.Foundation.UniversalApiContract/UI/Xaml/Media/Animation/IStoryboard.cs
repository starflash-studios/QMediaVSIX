// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IStoryboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3562806894, 13716, 17934, 152, 26, 50, 39, 27, 211, 170, 6)]
  [ExclusiveTo(typeof (Storyboard))]
  [WebHostHidden]
  internal interface IStoryboard
  {
    TimelineCollection Children { get; }

    void Seek(TimeSpan offset);

    void Stop();

    void Begin();

    void Pause();

    void Resume();

    ClockState GetCurrentState();

    TimeSpan GetCurrentTime();

    void SeekAlignedToLastTick(TimeSpan offset);

    void SkipToFill();
  }
}
