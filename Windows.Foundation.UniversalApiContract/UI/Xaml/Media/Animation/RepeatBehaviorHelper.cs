// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepeatBehaviorHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides basic utility methods for processing RepeatBehavior values. C# and Microsoft Visual Basic code should use members of RepeatBehavior instead.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRepeatBehaviorHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RepeatBehaviorHelper : IRepeatBehaviorHelper
  {
    /// <summary>Gets a static RepeatBehavior that represents the special "Forever" value. C# and Microsoft Visual Basic code should use Forever instead.</summary>
    /// <returns>A static RepeatBehavior that represents the special "Forever" value.</returns>
    public static extern RepeatBehavior Forever { [MethodImpl] get; }

    /// <summary>Creates a new RepeatBehavior based on a repeat count. This corresponds to the *int***x** form when provided as XAML attribute value. C# and Microsoft Visual Basic code should use RepeatBehavior(Double) instead.</summary>
    /// <param name="count">The number of times that the target animation should repeat.</param>
    /// <returns>The created RepeatBehavior, which has a **RepeatBehaviorType** of **Count**.</returns>
    [MethodImpl]
    public static extern RepeatBehavior FromCount(double count);

    [MethodImpl]
    public static extern RepeatBehavior FromDuration(TimeSpan duration);

    /// <summary>Returns whether a specified RepeatBehavior has a **RepeatBehaviorType** of **Count** and a nonzero **Count** value. C# and Microsoft Visual Basic code should use HasCount instead.</summary>
    /// <param name="target">The RepeatBehavior to evaluate.</param>
    /// <returns>**true** if *target* has a **RepeatBehaviorType** of **Count** and a nonzero **Count** value. Otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetHasCount(RepeatBehavior target);

    /// <summary>Returns whether a specified RepeatBehavior has a **RepeatBehaviorType** of **Duration** and a nonzero **Duration** value. C# and Microsoft Visual Basic code should use HasDuration instead.</summary>
    /// <param name="target">The RepeatBehavior to evaluate.</param>
    /// <returns>**true** if *target* has a **RepeatBehaviorType** of **Duration** and a nonzero **Duration** value. Otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetHasDuration(RepeatBehavior target);

    /// <summary>Determines whether two RepeatBehavior values have equivalent values. C# and Microsoft Visual Basic code should use the equality operator instead.</summary>
    /// <param name="target">The first RepeatBehavior to compare.</param>
    /// <param name="value">The second RepeatBehavior to compare.</param>
    /// <returns>**true** if *target* and *value* hold equivalent values; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Equals(RepeatBehavior target, RepeatBehavior value);
  }
}
