// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XmlnsDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Specifies a mapping on a per-assembly basis between a XAML namespace and a library-code namespace for backing types, which is then used for type resolution by a XAML object writer or XAML schema context.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct XmlnsDefinition
  {
    /// <summary>The XAML namespace identifier specified in the attribute.</summary>
    public string XmlNamespace;
    /// <summary>The library-code namespace, specified as a string.</summary>
    public string Namespace;
  }
}
