// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container for an item in a ListView control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IListViewItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ListViewItem : SelectorItem, IListViewItem
  {
    /// <summary>Initializes a new instance of the ListViewItem class.</summary>
    [MethodImpl]
    public extern ListViewItem();

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when you're defining templates for a ListViewItem class.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ListViewItemTemplateSettings TemplateSettings { [MethodImpl] get; }
  }
}
