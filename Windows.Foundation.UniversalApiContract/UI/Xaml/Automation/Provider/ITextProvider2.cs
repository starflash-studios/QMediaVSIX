// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Extends the ITextProvider interface to enable Microsoft UI Automation providers to expose textual content that is the target of an annotation or selection. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Text2.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3743238332, 1159, 20095, 157, 94, 240, 158, 119, 228, 18, 70)]
  public interface ITextProvider2 : ITextProvider
  {
    /// <summary>Exposes a text range that contains the text that is the target of the annotation associated with the specified annotation element.</summary>
    /// <param name="annotationElement">The provider for an element that implements the IAnnotationProvider interface. The annotation element is a sibling of the element that implements the ITextProvider2 interface for the document. </param>
    /// <returns>A text range that contains the annotation target text.</returns>
    ITextRangeProvider RangeFromAnnotation(
      IRawElementProviderSimple annotationElement);

    /// <summary>Retrieves a zero-length text range at the location of the caret that belongs to the text-based control.</summary>
    /// <param name="isActive">**true** if the text-based control that contains the caret has keyboard focus; otherwise, **false**.</param>
    /// <returns>A text range that represents the current location of the caret that belongs to the text-based control.</returns>
    ITextRangeProvider GetCaretRange(out bool isActive);
  }
}
