// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1909075979, 47262, 16772, 176, 223, 169, 233, 84, 71, 222, 141)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GroupStyle))]
  internal interface IGroupStyle
  {
    ItemsPanelTemplate Panel { get; set; }

    Style ContainerStyle { [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    StyleSelector ContainerStyleSelector { [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    DataTemplate HeaderTemplate { get; set; }

    DataTemplateSelector HeaderTemplateSelector { get; set; }

    bool HidesIfEmpty { get; set; }
  }
}
