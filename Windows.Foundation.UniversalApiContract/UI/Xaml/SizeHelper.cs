// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SizeHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides helper methods to evaluate or set Size values. C# and Microsoft Visual Basic code should use members of Size instead.</summary>
  [Static(typeof (ISizeHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class SizeHelper : ISizeHelper
  {
    /// <summary>Gets a static Size value where the Size has no height or width (all values 0). C# and Microsoft Visual Basic code should use Size.Empty instead.</summary>
    /// <returns>A Size with all values as 0.</returns>
    public static extern Size Empty { [MethodImpl] get; }

    /// <summary>Creates a new Size based on width and height element values. C# and Microsoft Visual Basic code should use the Size(Double,Double) constructor instead.</summary>
    /// <param name="width">The initial **Width**.</param>
    /// <param name="height">The initial **Height**.</param>
    /// <returns>The created Size.</returns>
    [MethodImpl]
    public static extern Size FromDimensions(float width, float height);

    /// <summary>Returns whether a specified Size is equivalent to an Empty Size. C# and Microsoft Visual Basic code should use Size.IsEmpty instead.</summary>
    /// <param name="target">The Size to evaluate.</param>
    /// <returns>**true** if the specified Size is equivalent to an Empty Size; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsEmpty(Size target);

    /// <summary>Provides comparison of the values of two Size values. C# and Microsoft Visual Basic code should use the Equality (=) operator or Equals method instead.</summary>
    /// <param name="target">The first Size to compare.</param>
    /// <param name="value">The second Size to compare.</param>
    /// <returns>**true** if *target* and *value* hold equivalent values; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Equals(Size target, Size value);
  }
}
