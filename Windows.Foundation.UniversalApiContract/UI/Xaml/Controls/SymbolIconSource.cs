// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SymbolIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon source that uses a glyph from the Segoe MDL2 Assets font as its content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISymbolIconSourceFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISymbolIconSourceStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public class SymbolIconSource : IconSource, ISymbolIconSource
  {
    /// <summary>Initializes a new instance of the SymbolIconSource class.</summary>
    [MethodImpl]
    public extern SymbolIconSource();

    /// <summary>Gets or sets the Segoe MDL2 Assets glyph used as the icon content.</summary>
    /// <returns>A named constant of the numeration that specifies the Segoe MDL2 Assets glyph to use.</returns>
    public extern Symbol Symbol { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Symbol dependency property.</summary>
    /// <returns>The identifier for the Symbol dependency property.</returns>
    public static extern DependencyProperty SymbolProperty { [MethodImpl] get; }
  }
}
