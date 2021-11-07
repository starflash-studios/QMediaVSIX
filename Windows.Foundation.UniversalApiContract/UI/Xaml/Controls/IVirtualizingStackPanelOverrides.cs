// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingStackPanelOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3420911404, 10386, 18129, 152, 127, 88, 202, 16, 129, 240, 64)]
  [ExclusiveTo(typeof (VirtualizingStackPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IVirtualizingStackPanelOverrides
  {
    void OnCleanUpVirtualizedItem(CleanUpVirtualizedItemEventArgs e);
  }
}
