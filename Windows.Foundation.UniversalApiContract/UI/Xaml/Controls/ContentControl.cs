// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control with a single piece of content. Controls such as Button, CheckBox, and ScrollViewer directly or indirectly inherit from this class.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Composable(typeof (IContentControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IContentControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ContentControl : Control, IContentControl, IContentControl2, IContentControlOverrides
  {
    /// <summary>Initializes a new instance of the ContentControl class.</summary>
    [MethodImpl]
    public extern ContentControl();

    /// <summary>Gets or sets the content of a ContentControl.</summary>
    /// <returns>An object that contains the control's content. The default is **null**.</returns>
    public extern object Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the data template that is used to display the content of the ContentControl.</summary>
    /// <returns>The data template that is used to display the content of the ContentControl.</returns>
    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a selection object that changes the DataTemplate to apply for content, based on processing information about the content item or its container at run time.</summary>
    /// <returns>A selection object that changes the DataTemplate to apply for content.</returns>
    public extern DataTemplateSelector ContentTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the content of a ContentControl.</summary>
    /// <returns>The strongly typed collection of Transition style elements.</returns>
    public extern TransitionCollection ContentTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the root element of the data template specified by the ContentTemplate property.</summary>
    /// <returns>The root element of the data template specified by the ContentTemplate property. The default is **null**.</returns>
    public extern UIElement ContentTemplateRoot { [MethodImpl] get; }

    [MethodImpl]
    extern void IContentControlOverrides.OnContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IContentControlOverrides.OnContentTemplateChanged(
      DataTemplate oldContentTemplate,
      DataTemplate newContentTemplate);

    [MethodImpl]
    extern void IContentControlOverrides.OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);

    /// <summary>Identifies the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTemplate dependency property</summary>
    /// <returns>The identifier for the ContentTemplate dependency property.</returns>
    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTemplateSelector dependency property.</summary>
    /// <returns>The identifier for the ContentTemplateSelector dependency property.</returns>
    public static extern DependencyProperty ContentTemplateSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTransitions dependency property.</summary>
    /// <returns>The identifier for the ContentTransitions dependency property.</returns>
    public static extern DependencyProperty ContentTransitionsProperty { [MethodImpl] get; }
  }
}
