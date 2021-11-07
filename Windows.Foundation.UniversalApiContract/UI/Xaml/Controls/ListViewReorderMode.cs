// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewReorderMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the reorder mode of a ListView or GridView.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ListViewReorderMode
  {
    /// <summary>A user can't reorder the list.</summary>
    Disabled,
    /// <summary>A user can reorder the list.</summary>
    Enabled,
  }
}
