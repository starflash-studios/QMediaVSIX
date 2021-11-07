// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.GridViewItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a GridView control. Not intended for general use.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GridViewItemTemplateSettings : DependencyObject, IGridViewItemTemplateSettings
  {
    /// <summary>Gets a value that reports the count of items in the current drag operation.</summary>
    /// <returns>A value that reports the count of items in the current drag operation.</returns>
    public extern int DragItemsCount { [MethodImpl] get; }
  }
}
