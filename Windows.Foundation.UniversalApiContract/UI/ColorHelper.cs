// Decompiled with JetBrains decompiler
// Type: Windows.UI.ColorHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  /// <summary>Provides static helper methods for processing Color values. C# and Microsoft Visual Basic code should use methods of Color instead.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IColorHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorHelperStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ColorHelper : IColorHelper
  {
    /// <summary>Retrieves the display name of the specified color.</summary>
    /// <param name="color">The color to get the name for.</param>
    /// <returns>The localized display name of the color.</returns>
    [MethodImpl]
    public static extern string ToDisplayName(Color color);

    /// <summary>Generates a Color structure, based on discrete **Byte** values for **ARGB** components. C# and Microsoft Visual Basic code should use **Color.FromArgb** instead.</summary>
    /// <param name="a">The **A** (transparency) component of the desired color. Range is 0-255.</param>
    /// <param name="r">The **R** component of the desired color. Range is 0-255.</param>
    /// <param name="g">The **G** component of the desired color. Range is 0-255.</param>
    /// <param name="b">The **B** component of the desired color. Range is 0-255.</param>
    /// <returns>The generated Color value.</returns>
    [MethodImpl]
    public static extern Color FromArgb(byte a, byte r, byte g, byte b);
  }
}
