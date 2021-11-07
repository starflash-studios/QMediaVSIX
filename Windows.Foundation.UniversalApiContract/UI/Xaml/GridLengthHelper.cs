// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.GridLengthHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides helper methods to evaluate or set GridLength values. C# and Microsoft Visual Basic code should use methods of GridLength instead.</summary>
  [Static(typeof (IGridLengthHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GridLengthHelper : IGridLengthHelper
  {
    /// <summary>Gets a static GridLength value that corresponds to the special "Auto" value. C# and Microsoft Visual Basic code should use GridLength.Auto instead.</summary>
    /// <returns>A GridLength value that corresponds to the special "Auto" value.</returns>
    public static extern GridLength Auto { [MethodImpl] get; }

    /// <summary>Creates a new GridLength value based on a fixed number of pixels. C# and Microsoft Visual Basic code should use the GridLength(Double) constructor instead.</summary>
    /// <param name="pixels">The pixel height or width to specify.</param>
    /// <returns>The created GridLength.</returns>
    [MethodImpl]
    public static extern GridLength FromPixels(double pixels);

    /// <summary>Creates a new GridLength value based on a possible number of pixels, and a GridUnitType. C# and Microsoft Visual Basic code should use the  GridLength(Double,GridUnitType) constructor instead.</summary>
    /// <param name="value">A numeric value. This might be a pixel height or width to specify, if *type* is specified as **Pixel**, or a factor, if *type* is specified as **Star**. This value is ignored if *type* is specified as **Auto**.</param>
    /// <param name="type">A value of the enumeration that specifies which unit type the GridLength represents.</param>
    /// <returns>The created GridLength.</returns>
    [MethodImpl]
    public static extern GridLength FromValueAndType(double value, GridUnitType type);

    /// <summary>Returns whether the evaluated GridLength is the special "Absolute" value. C# and Microsoft Visual Basic code should use GridLength.IsAbsolute instead.</summary>
    /// <param name="target">The GridLength to evaluate.</param>
    /// <returns>**true** if the evaluated GridLength is the special "Absolute" value; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsAbsolute(GridLength target);

    /// <summary>Returns whether the evaluated GridLength is the special "Auto" value. C# and Microsoft Visual Basic code should use GridLength.IsAuto instead.</summary>
    /// <param name="target">The GridLength to evaluate.</param>
    /// <returns>**true** if the evaluated GridLength is the special "Auto" value; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsAuto(GridLength target);

    /// <summary>Returns whether the evaluated GridLength is the special "*" (star sizing) value. C# and Microsoft Visual Basic code should use GridLength.IsStar instead.</summary>
    /// <param name="target">The GridLength to evaluate.</param>
    /// <returns>**true** if the evaluated GridLength is the special "*" (star sizing) value; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsStar(GridLength target);

    /// <summary>Provides comparison of the values of two GridLength values. C# and Microsoft Visual Basic code should use the Equality operator or GridLength.Equals method instead.</summary>
    /// <param name="target">The first GridLength to compare.</param>
    /// <param name="value">The second GridLength to compare.</param>
    /// <returns>**true** if the two GridLength values hold equivalent values as their structure value information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Equals(GridLength target, GridLength value);
  }
}
