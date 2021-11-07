// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the selection mode of a ListView or GridView.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ListViewSelectionMode
  {
    /// <summary>A user can't select items.</summary>
    None,
    /// <summary>A user can select a single item.</summary>
    Single,
    /// <summary>The user can select multiple items without entering a special mode.</summary>
    Multiple,
    /// <summary>The user can select multiple items by entering a special mode, for example when depressing a modifier key.</summary>
    Extended,
  }
}
