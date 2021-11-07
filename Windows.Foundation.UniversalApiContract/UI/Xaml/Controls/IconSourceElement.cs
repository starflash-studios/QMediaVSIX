// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IconSourceElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon that uses an IconSource as its content.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IIconSourceElementStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IIconSourceElementFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ContentProperty(Name = "IconSource")]
  public class IconSourceElement : IconElement, IIconSourceElement
  {
    /// <summary>Initializes a new instance of the IconSourceElement class.</summary>
    [MethodImpl]
    public extern IconSourceElement();

    /// <summary>Gets or sets the IconSource used as the icon content.</summary>
    /// <returns>The IconSource used as the icon content. The default is **null**.</returns>
    public extern IconSource IconSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IconSource dependency property.</summary>
    /// <returns>The identifier for the IconSource dependency property.</returns>
    public static extern DependencyProperty IconSourceProperty { [MethodImpl] get; }
  }
}
