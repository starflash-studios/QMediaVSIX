// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RevealBrushState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines constants that specify the pointer state of an element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public enum RevealBrushState
  {
    /// <summary>The element is in its default state.</summary>
    Normal,
    /// <summary>The pointer is over the element.</summary>
    PointerOver,
    /// <summary>The element is pressed.</summary>
    Pressed,
  }
}
