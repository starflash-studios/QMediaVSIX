// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HubSection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a single group of content in a Hub.</summary>
  [Static(typeof (IHubSectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IHubSectionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "ContentTemplate")]
  public class HubSection : Control, IHubSection
  {
    /// <summary>Initializes a new instance of the HubSection class.</summary>
    [MethodImpl]
    public extern HubSection();

    /// <summary>Gets or sets the content for the hub section header.</summary>
    /// <returns>The content of the section header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the hub section header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the data template that is used to display the content of the HubSection.</summary>
    /// <returns>The data template that is used to display the content of the HubSection.</returns>
    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the section header raises a SectionHeaderClick event on its containing Hub.</summary>
    /// <returns>**true** if the section header raises a SectionHeaderClick event; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsHeaderInteractive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTemplate dependency property.</summary>
    /// <returns>The identifier for the ContentTemplate dependency property.</returns>
    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHeaderInteractive dependency property.</summary>
    /// <returns>The identifier for the IsHeaderInteractive dependency property.</returns>
    public static extern DependencyProperty IsHeaderInteractiveProperty { [MethodImpl] get; }
  }
}
