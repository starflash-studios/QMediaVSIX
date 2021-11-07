// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlMetadataProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Implements XAML schema context concepts that support XAML parsing.</summary>
  [WebHostHidden]
  [Guid(3010878825, 26789, 19250, 136, 97, 253, 185, 12, 31, 88, 54)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXamlMetadataProvider
  {
    [DefaultOverload]
    [Overload("GetXamlType")]
    IXamlType GetXamlType(TypeName type);

    /// <summary>Implements XAML schema context access to underlying type mapping, based on specifying a full type name.</summary>
    /// <param name="fullName">The name of the class for which to return a XAML type mapping.</param>
    /// <returns>The schema context's implementation of the IXamlType concept.</returns>
    [Overload("GetXamlTypeByFullName")]
    IXamlType GetXamlType(string fullName);

    /// <summary>Gets the set of XMLNS (XAML namespace) definitions that apply to the context.</summary>
    /// <returns>The set of XMLNS (XAML namespace) definitions.</returns>
    XmlnsDefinition[] GetXmlnsDefinitions();
  }
}
