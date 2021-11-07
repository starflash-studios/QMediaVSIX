// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepeatBehaviorType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies the repeat mode that a RepeatBehavior raw value represents.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RepeatBehaviorType
  {
    /// <summary>The RepeatBehavior represents a case where the timeline should repeat for a fixed number of complete runs.</summary>
    Count,
    /// <summary>The RepeatBehavior represents a case where the timeline should repeat for a time duration, which might result in an animation terminating part way through.</summary>
    Duration,
    /// <summary>The RepeatBehavior represents a case where the timeline should repeat indefinitely.</summary>
    Forever,
  }
}
