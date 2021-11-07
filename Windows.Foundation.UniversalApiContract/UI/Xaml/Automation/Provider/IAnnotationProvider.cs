// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IAnnotationProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes the properties of an annotation in a document. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Annotation.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2512000023, 17463, 17691, 148, 97, 5, 10, 73, 181, 157, 6)]
  public interface IAnnotationProvider
  {
    /// <summary>Gets the annotation type identifier of this annotation.</summary>
    /// <returns>The annotation type identifier of this annotation.</returns>
    int AnnotationTypeId { get; }

    /// <summary>Gets the name of this annotation type.</summary>
    /// <returns>The name of this annotation type.</returns>
    string AnnotationTypeName { get; }

    /// <summary>Gets the name of the annotation author.</summary>
    /// <returns>The name of the annotation author.</returns>
    string Author { get; }

    /// <summary>Gets the date and time when this annotation was created.</summary>
    /// <returns>The date and time when this annotation was created.</returns>
    string DateTime { get; }

    /// <summary>Gets the UI Automation element that is being annotated.</summary>
    /// <returns>The UI Automation element that is being annotated.</returns>
    IRawElementProviderSimple Target { get; }
  }
}
