// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ThemeShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>A ThemeShadow is a preconfigured shadow effect that can be applied to any XAML element to draw shadows appropriately based on x, y, z coordinates. ThemeShadow also automatically adjusts for other environmental specifications:</summary>
  [Composable(typeof (IThemeShadowFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class ThemeShadow : Shadow, IThemeShadow
  {
    /// <summary>Initializes a new instance of the ThemeShadow class.</summary>
    [MethodImpl]
    public extern ThemeShadow();

    /// <summary>Gets a collection of UI elements that this ThemeShadow is cast on.</summary>
    /// <returns>A collection of UI elements that this ThemeShadow is cast on.</returns>
    public extern UIElementWeakCollection Receivers { [MethodImpl] get; }
  }
}
