// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.BackgroundSizing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how far an element's background extends in relation to the element's border.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  public enum BackgroundSizing
  {
    /// <summary>The element's background extends to the inner edge of the border, but does not extend under the border.</summary>
    InnerBorderEdge,
    /// <summary>The element's background extends under the border to its outer edge, and is visible if the border is transparent.</summary>
    OuterBorderEdge,
  }
}
