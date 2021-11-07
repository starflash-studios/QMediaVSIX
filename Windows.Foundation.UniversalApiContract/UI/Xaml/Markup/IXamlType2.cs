// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlType2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides the means to report XAML-type system specifics about XAML types. Using this interface contract, XAML parsers can load any custom types and members thereof that are defined in your app and are referenced in XAML files.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2668391995, 17211, 22189, 143, 105, 120, 164, 221, 62, 100, 249)]
  public interface IXamlType2 : IXamlType
  {
    /// <summary>Gets the IXamlType for the boxed type of the XAML type. Determination of this value is based on the underlying type for core types.</summary>
    /// <returns>The IXamlType for the boxed type of the XAML type.</returns>
    IXamlType BoxedType { get; }
  }
}
