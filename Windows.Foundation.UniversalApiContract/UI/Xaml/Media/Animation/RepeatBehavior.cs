// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepeatBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Describes how a Timeline repeats its simple duration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct RepeatBehavior
  {
    /// <summary>The number of times a Timeline should repeat.</summary>
    public double Count;
    /// <summary>The time span for which a Timeline should repeat.</summary>
    public TimeSpan Duration;
    /// <summary>The mode or type of repeat behavior that this instance represents, as a value of the enumeration.</summary>
    public RepeatBehaviorType Type;
  }
}
