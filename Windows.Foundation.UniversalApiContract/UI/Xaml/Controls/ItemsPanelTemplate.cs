// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsPanelTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies the panel that the ItemsPresenter creates for the layout of the items of an ItemsControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class ItemsPanelTemplate : FrameworkTemplate, IItemsPanelTemplate
  {
    /// <summary>Initializes a new instance of the ItemsPanelTemplate class.</summary>
    [MethodImpl]
    public extern ItemsPanelTemplate();
  }
}
