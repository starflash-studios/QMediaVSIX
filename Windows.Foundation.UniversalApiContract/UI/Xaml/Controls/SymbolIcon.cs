// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SymbolIcon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon that uses a glyph from the Segoe MDL2 Assets font as its content.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISymbolIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISymbolIconFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SymbolIcon : IconElement, ISymbolIcon
  {
    /// <summary>Initializes a new instance of the SymbolIcon class using the specified symbol.</summary>
    /// <param name="symbol">A named constant of the enumeration that specifies the Segoe MDL2 Assets glyph to use. The default is **null**.</param>
    [MethodImpl]
    public extern SymbolIcon(Symbol symbol);

    /// <summary>Initializes a new instance of the SymbolIcon class.</summary>
    [MethodImpl]
    public extern SymbolIcon();

    /// <summary>Gets or sets the Segoe MDL2 Assets glyph used as the icon content.</summary>
    /// <returns>A named constant of the numeration that specifies the Segoe MDL2 Assets glyph to use.</returns>
    public extern Symbol Symbol { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Symbol dependency property.</summary>
    /// <returns>The identifier for the Symbol dependency property.</returns>
    public static extern DependencyProperty SymbolProperty { [MethodImpl] get; }
  }
}
