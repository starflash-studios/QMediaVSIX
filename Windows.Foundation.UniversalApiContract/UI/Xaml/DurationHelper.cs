// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DurationHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides basic utility methods for processing Duration values. C# and Microsoft Visual Basic code should use methods of Duration instead.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDurationHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DurationHelper : IDurationHelper
  {
    /// <summary>Returns a generated Duration value that indicates an "Automatic" Duration. C# and Microsoft Visual Basic code should use Duration.Automatic instead.</summary>
    /// <returns>A Duration value that indicates an "Automatic" Duration.</returns>
    public static extern Duration Automatic { [MethodImpl] get; }

    /// <summary>Returns a generated Duration value that indicates a "Forever" Duration. C# and Microsoft Visual Basic code should use Duration.Forever instead.</summary>
    /// <returns>A Duration value that indicates a "Forever" Duration.</returns>
    public static extern Duration Forever { [MethodImpl] get; }

    /// <summary>Compares value equality of two Duration structures. C# and Microsoft Visual Basic code should use Duration.Compare instead.</summary>
    /// <param name="duration1">The first Duration to compare.</param>
    /// <param name="duration2">The second Duration to compare.</param>
    /// <returns>If *duration1* is less than *duration2*, a negative value that represents the difference. If *duration1* is equal to *duration2*, zero. If *duration1* is greater than *duration2*, a positive value that represents the difference.</returns>
    [MethodImpl]
    public static extern int Compare(Duration duration1, Duration duration2);

    [MethodImpl]
    public static extern Duration FromTimeSpan(TimeSpan timeSpan);

    /// <summary>Returns whether the **TimeSpan** component of a given Duration holds a non-null value. C# and Microsoft Visual Basic code should use Duration.HasTimeSpan instead.</summary>
    /// <param name="target">The Duration value to evaluate.</param>
    /// <returns>**true** if the **TimeSpan** component of the provided Duration is not **null**; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetHasTimeSpan(Duration target);

    /// <summary>Adds the **TimeSpan** component of two Duration values. C# and Microsoft Visual Basic code should use the Addition (+) operator or the Duration.Add method instead.</summary>
    /// <param name="target">The value to add to.</param>
    /// <param name="duration">The value to add.</param>
    /// <returns>The resulting Duration after **TimeSpan** component addition.</returns>
    [MethodImpl]
    public static extern Duration Add(Duration target, Duration duration);

    /// <summary>Determines whether two Duration values have equivalent values. C# and Microsoft Visual Basic code should use the Equality (=) operator or Duration.Equals method instead.</summary>
    /// <param name="target">The first Duration to compare.</param>
    /// <param name="value">The second Duration to compare.</param>
    /// <returns>**true** if *target* and *value* hold equivalent values; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Equals(Duration target, Duration value);

    /// <summary>Subtracts the **TimeSpan** component of one Duration value from another Duration value. C# and Microsoft Visual Basic code should use the Subtraction (-) operator or the Duration.Subtract method instead.</summary>
    /// <param name="target">The value to subtract from.</param>
    /// <param name="duration">The value to subtract.</param>
    /// <returns>The resulting Duration after **TimeSpan** component subtraction.</returns>
    [MethodImpl]
    public static extern Duration Subtract(Duration target, Duration duration);
  }
}
