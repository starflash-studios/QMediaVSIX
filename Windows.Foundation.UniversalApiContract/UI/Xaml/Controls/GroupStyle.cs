// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.GroupStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Describes how to display the grouped items in a collection, such as the collection from GroupItems.</summary>
  [WebHostHidden]
  [Composable(typeof (IGroupStyleFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class GroupStyle : IGroupStyle, IGroupStyle2, INotifyPropertyChanged
  {
    /// <summary>Initializes a new instance of the GroupStyle class.</summary>
    [MethodImpl]
    public extern GroupStyle();

    /// <summary>Gets or sets a template that creates the panel used to lay out the items.</summary>
    /// <returns>An ItemsPanelTemplate object that creates the panel used to layout the items.</returns>
    public extern ItemsPanelTemplate Panel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style that is applied to the GroupItem generated for each item.</summary>
    /// <returns>The style that is applied to the GroupItem generated for each item. The default is **null**.</returns>
    public extern Style ContainerStyle { [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom StyleSelector logic class. The StyleSelector referenced by this property returns a style to apply to each generated GroupItem.</summary>
    /// <returns>An object that derives from StyleSelector. The default is **null**.</returns>
    public extern StyleSelector ContainerStyleSelector { [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the template that is used to display the group header.</summary>
    /// <returns>A DataTemplate object that is used to display the group header. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector returns different DataTemplate values to use for the header area of group item content.</summary>
    /// <returns>An object that derives from DataTemplateSelector. The default is **null**.</returns>
    public extern DataTemplateSelector HeaderTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether items corresponding to empty groups should be displayed.</summary>
    /// <returns>**True** to not display empty groups; otherwise, **false**. The default is **false**.</returns>
    public extern bool HidesIfEmpty { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style that is applied to the header for each item.</summary>
    /// <returns>The style that is applied to the header for each item. The default is **null**.</returns>
    public extern Style HeaderContainerStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern event PropertyChangedEventHandler PropertyChanged;
  }
}
