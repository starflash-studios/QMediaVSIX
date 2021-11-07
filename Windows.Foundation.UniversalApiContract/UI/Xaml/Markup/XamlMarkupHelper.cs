// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlMarkupHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides helper methods for the XAML compiler.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IXamlMarkupHelperStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class XamlMarkupHelper : IXamlMarkupHelper
  {
    /// <summary>Unloads an element from the XAML visual tree.</summary>
    /// <param name="element">The element to unload.</param>
    [MethodImpl]
    public static extern void UnloadObject(DependencyObject element);
  }
}
