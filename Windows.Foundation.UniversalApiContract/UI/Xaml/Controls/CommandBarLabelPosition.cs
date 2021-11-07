// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBarLabelPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the placement and visibility of an app bar button's label.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum CommandBarLabelPosition
  {
    /// <summary>The placement and visibility of the app bar button's label is determined by the value of the CommandBar.DefaultLabelPosition property.</summary>
    Default,
    /// <summary>The app bar button's label is always hidden whether the command bar is open or closed.</summary>
    Collapsed,
  }
}
