// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.MarkupExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides a base class for XAML markup extension implementations.</summary>
  [Composable(typeof (IMarkupExtensionFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class MarkupExtension : IMarkupExtension, IMarkupExtensionOverrides
  {
    /// <summary>Initializes a new instance of the MarkupExtension class.</summary>
    [MethodImpl]
    public extern MarkupExtension();

    [MethodImpl]
    extern object IMarkupExtensionOverrides.ProvideValue();
  }
}
