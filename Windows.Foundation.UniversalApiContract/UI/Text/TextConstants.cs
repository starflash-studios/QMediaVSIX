// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextConstants
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines a set of constants that are used with various methods in the Windows.UI.Text namespace.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITextConstantsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public static class TextConstants
  {
    /// <summary>Gets the default color.</summary>
    /// <returns>The default color.</returns>
    public static extern Color AutoColor { [MethodImpl] get; }

    /// <summary>Gets the minimum unit count.</summary>
    /// <returns>The minimum unit count.</returns>
    public static extern int MinUnitCount { [MethodImpl] get; }

    /// <summary>Gets the maximum unit count.</summary>
    /// <returns>The maximum unit count.</returns>
    public static extern int MaxUnitCount { [MethodImpl] get; }

    /// <summary>Gets the undefined color value.</summary>
    /// <returns>The undefined color.</returns>
    public static extern Color UndefinedColor { [MethodImpl] get; }

    /// <summary>Gets the undefined floating-point value.</summary>
    /// <returns>The undefined floating-point value.</returns>
    public static extern float UndefinedFloatValue { [MethodImpl] get; }

    /// <summary>Gets the undefined 32-bit integer value.</summary>
    /// <returns>The undefined 32-bit integer value.</returns>
    public static extern int UndefinedInt32Value { [MethodImpl] get; }

    /// <summary>Gets the undefined font stretch value.</summary>
    /// <returns>The undefined font stretch value.</returns>
    public static extern FontStretch UndefinedFontStretch { [MethodImpl] get; }

    /// <summary>Gets the undefined font style.</summary>
    /// <returns>The undefined font style.</returns>
    public static extern FontStyle UndefinedFontStyle { [MethodImpl] get; }
  }
}
