// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ListViewItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ListViewItem. Not intended for general use.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ListViewItemTemplateSettings : DependencyObject, IListViewItemTemplateSettings
  {
    /// <summary>Gets the number of items for a drag payload that contains this item as an origin.</summary>
    /// <returns>The number of items for a drag payload.</returns>
    public extern int DragItemsCount { [MethodImpl] get; }
  }
}
