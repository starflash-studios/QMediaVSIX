// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  /// <summary>Creates an element tree of elements. FrameworkTemplate is a base class for classes that have specific templating behavior, including ControlTemplate and DataTemplate.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IFrameworkTemplateFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Template")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class FrameworkTemplate : DependencyObject, IFrameworkTemplate
  {
    /// <summary>Provides base class initialization behavior for FrameworkTemplate -derived classes.</summary>
    [MethodImpl]
    protected extern FrameworkTemplate();
  }
}
