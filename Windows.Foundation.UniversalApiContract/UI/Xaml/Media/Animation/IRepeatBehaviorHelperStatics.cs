// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepeatBehaviorHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (RepeatBehaviorHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2054770739, 31219, 19929, 178, 103, 156, 245, 15, 181, 31, 132)]
  internal interface IRepeatBehaviorHelperStatics
  {
    RepeatBehavior Forever { get; }

    RepeatBehavior FromCount(double count);

    RepeatBehavior FromDuration(TimeSpan duration);

    bool GetHasCount(RepeatBehavior target);

    bool GetHasDuration(RepeatBehavior target);

    bool Equals(RepeatBehavior target, RepeatBehavior value);
  }
}
