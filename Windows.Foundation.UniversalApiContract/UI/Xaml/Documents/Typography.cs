// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Typography
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides access to a set of Microsoft OpenType typography properties. These properties are implemented as XAML attached properties such that they can be set from text object model properties as well as from specific text controls.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITypographyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Typography : ITypography
  {
    /// <summary>Identifies the AnnotationAlternates attached property.</summary>
    /// <returns>The identifier for the AnnotationAlternates attached property.</returns>
    public static extern DependencyProperty AnnotationAlternatesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the AnnotationAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the AnnotationAlternates property.</param>
    /// <returns>The current value of the AnnotationAlternates attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern int GetAnnotationAlternates(DependencyObject element);

    /// <summary>Sets the value of the AnnotationAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the AnnotationAlternates property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetAnnotationAlternates(DependencyObject element, int value);

    /// <summary>Identifies the EastAsianExpertForms attached property.</summary>
    /// <returns>The identifier for the EastAsianExpertForms attached property.</returns>
    public static extern DependencyProperty EastAsianExpertFormsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the EastAsianExpertForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the EastAsianExpertForms property.</param>
    /// <returns>The current value of the EastAsianExpertForms attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetEastAsianExpertForms(DependencyObject element);

    /// <summary>Sets the value of the EastAsianExpertForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the EastAsianExpertForms property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetEastAsianExpertForms(DependencyObject element, bool value);

    /// <summary>Identifies the EastAsianLanguage attached property.</summary>
    /// <returns>The identifier for the EastAsianLanguage attached property.</returns>
    public static extern DependencyProperty EastAsianLanguageProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the EastAsianLanguage attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the EastAsianLanguage property.</param>
    /// <returns>The current value of the EastAsianLanguage attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontEastAsianLanguage GetEastAsianLanguage(
      DependencyObject element);

    /// <summary>Sets the value of the EastAsianLanguage attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the EastAsianLanguage property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetEastAsianLanguage(
      DependencyObject element,
      FontEastAsianLanguage value);

    /// <summary>Identifies the EastAsianWidths attached property.</summary>
    /// <returns>The identifier for the EastAsianWidths attached property.</returns>
    public static extern DependencyProperty EastAsianWidthsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the EastAsianWidths attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the EastAsianWidths property.</param>
    /// <returns>The current value of the EastAsianWidths attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontEastAsianWidths GetEastAsianWidths(
      DependencyObject element);

    /// <summary>Sets the value of the EastAsianWidths attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the EastAsianWidths property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetEastAsianWidths(
      DependencyObject element,
      FontEastAsianWidths value);

    /// <summary>Identifies the StandardLigatures attached property.</summary>
    /// <returns>The identifier for the StandardLigatures attached property.</returns>
    public static extern DependencyProperty StandardLigaturesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the StandardLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StandardLigatures property.</param>
    /// <returns>The current value of the StandardLigatures attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStandardLigatures(DependencyObject element);

    /// <summary>Sets the value of the StandardLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StandardLigatures property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStandardLigatures(DependencyObject element, bool value);

    /// <summary>Identifies the ContextualLigatures attached property.</summary>
    /// <returns>The identifier for the ContextualLigatures attached property.</returns>
    public static extern DependencyProperty ContextualLigaturesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the ContextualLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the ContextualLigatures property.</param>
    /// <returns>The current value of the ContextualLigatures attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetContextualLigatures(DependencyObject element);

    /// <summary>Sets the value of the ContextualLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the ContextualLigatures property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetContextualLigatures(DependencyObject element, bool value);

    /// <summary>Identifies the DiscretionaryLigatures attached property.</summary>
    /// <returns>The identifier for the DiscretionaryLigatures attached property.</returns>
    public static extern DependencyProperty DiscretionaryLigaturesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the DiscretionaryLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the DiscretionaryLigatures property.</param>
    /// <returns>The current value of the DiscretionaryLigatures attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetDiscretionaryLigatures(DependencyObject element);

    /// <summary>Sets the value of the DiscretionaryLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the DiscretionaryLigatures property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetDiscretionaryLigatures(DependencyObject element, bool value);

    /// <summary>Identifies the HistoricalLigatures attached property.</summary>
    /// <returns>The identifier for the HistoricalLigatures attached property.</returns>
    public static extern DependencyProperty HistoricalLigaturesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the HistoricalLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the HistoricalLigatures property.</param>
    /// <returns>The current value of the HistoricalLigatures attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetHistoricalLigatures(DependencyObject element);

    /// <summary>Sets the value of the HistoricalLigatures attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the HistoricalLigatures property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetHistoricalLigatures(DependencyObject element, bool value);

    /// <summary>Identifies the StandardSwashes attached property.</summary>
    /// <returns>The identifier for the StandardSwashes attached property.</returns>
    public static extern DependencyProperty StandardSwashesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the StandardSwashes attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StandardSwashes property.</param>
    /// <returns>The current value of the StandardSwashes attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern int GetStandardSwashes(DependencyObject element);

    /// <summary>Sets the value of the StandardSwashes attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StandardSwashes property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStandardSwashes(DependencyObject element, int value);

    /// <summary>Identifies the ContextualSwashes attached property.</summary>
    /// <returns>The identifier for the ContextualSwashes attached property.</returns>
    public static extern DependencyProperty ContextualSwashesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the ContextualSwashes attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the ContextualSwashes property.</param>
    /// <returns>The current value of the ContextualSwashes attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern int GetContextualSwashes(DependencyObject element);

    /// <summary>Sets the value of the ContextualSwashes attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the ContextualSwashes property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetContextualSwashes(DependencyObject element, int value);

    /// <summary>Identifies the ContextualAlternates attached property.</summary>
    /// <returns>The identifier for the ContextualAlternates attached property.</returns>
    public static extern DependencyProperty ContextualAlternatesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the ContextualAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the ContextualAlternates property.</param>
    /// <returns>The current value of the ContextualAlternates attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetContextualAlternates(DependencyObject element);

    /// <summary>Sets the value of the ContextualAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the ContextualAlternates property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetContextualAlternates(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticAlternates attached property.</summary>
    /// <returns>The identifier for the StylisticAlternates attached property.</returns>
    public static extern DependencyProperty StylisticAlternatesProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticAlternates property.</param>
    /// <returns>The current value of the StylisticAlternates attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern int GetStylisticAlternates(DependencyObject element);

    /// <summary>Sets the value of the StylisticAlternates attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticAlternates property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticAlternates(DependencyObject element, int value);

    /// <summary>Identifies the StylisticSet1 attached property.</summary>
    /// <returns>The identifier for the StylisticSet1 attached property.</returns>
    public static extern DependencyProperty StylisticSet1Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet1 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet1 property.</param>
    /// <returns>The current value of the StylisticSet1 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet1(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet1 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet1 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet1(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet2 attached property.</summary>
    /// <returns>The identifier for the StylisticSet2 attached property.</returns>
    public static extern DependencyProperty StylisticSet2Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet2 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet2 property.</param>
    /// <returns>The current value of the StylisticSet2 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet2(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet2 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet2 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet2(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet3 attached property.</summary>
    /// <returns>The identifier for the StylisticSet3 attached property.</returns>
    public static extern DependencyProperty StylisticSet3Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet3 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet3 property.</param>
    /// <returns>The current value of the StylisticSet3 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet3(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet3 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet3 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet3(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet4 attached property.</summary>
    /// <returns>The identifier for the StylisticSet4 attached property.</returns>
    public static extern DependencyProperty StylisticSet4Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet4 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet4 property.</param>
    /// <returns>The current value of the StylisticSet4 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet4(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet4 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet4 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet4(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet5 attached property.</summary>
    /// <returns>The identifier for the StylisticSet5 attached property.</returns>
    public static extern DependencyProperty StylisticSet5Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet5 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet5 property.</param>
    /// <returns>The current value of the StylisticSet5 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet5(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet5 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet5 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet5(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet6 attached property.</summary>
    /// <returns>The identifier for the StylisticSet6 attached property.</returns>
    public static extern DependencyProperty StylisticSet6Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet6 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet6 property.</param>
    /// <returns>The current value of the StylisticSet6 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet6(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet6 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet6 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet6(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet7 attached property.</summary>
    /// <returns>The identifier for the StylisticSet7 attached property.</returns>
    public static extern DependencyProperty StylisticSet7Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet7 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet7 property.</param>
    /// <returns>The current value of the StylisticSet7 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet7(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet7 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet7 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet7(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet8 attached property.</summary>
    /// <returns>The identifier for the StylisticSet8 attached property.</returns>
    public static extern DependencyProperty StylisticSet8Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet8 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet8 property.</param>
    /// <returns>The current value of the StylisticSet8 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet8(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet8 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet8 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet8(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet9 attached property.</summary>
    /// <returns>The identifier for the StylisticSet9 attached property.</returns>
    public static extern DependencyProperty StylisticSet9Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet9 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet9 property.</param>
    /// <returns>The current value of the StylisticSet9 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet9(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet9 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet9 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet9(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet10 attached property.</summary>
    /// <returns>The identifier for the StylisticSet10 attached property.</returns>
    public static extern DependencyProperty StylisticSet10Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet10 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet10 property.</param>
    /// <returns>The current value of the StylisticSet10 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet10(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet10 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet10 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet10(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet11 attached property.</summary>
    /// <returns>The identifier for the StylisticSet11 attached property.</returns>
    public static extern DependencyProperty StylisticSet11Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet11 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet11 property.</param>
    /// <returns>The current value of the StylisticSet11 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet11(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet11 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet11 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet11(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet12 attached property.</summary>
    /// <returns>The identifier for the StylisticSet12 attached property.</returns>
    public static extern DependencyProperty StylisticSet12Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet12 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet12 property.</param>
    /// <returns>The current value of the StylisticSet12 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet12(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet12 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet12 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet12(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet13 attached property.</summary>
    /// <returns>The identifier for the StylisticSet13 attached property.</returns>
    public static extern DependencyProperty StylisticSet13Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet13 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet13 property.</param>
    /// <returns>The current value of the StylisticSet13 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet13(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet13 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet13 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet13(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet14 attached property.</summary>
    /// <returns>The identifier for the StylisticSet14 attached property.</returns>
    public static extern DependencyProperty StylisticSet14Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet14 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet14 property.</param>
    /// <returns>The current value of the StylisticSet14 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet14(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet14 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet14 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet14(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet15 attached property.</summary>
    /// <returns>The identifier for the StylisticSet15 attached property.</returns>
    public static extern DependencyProperty StylisticSet15Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet15 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet15 property.</param>
    /// <returns>The current value of the StylisticSet15 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet15(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet15 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet15 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet15(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet16 attached property.</summary>
    /// <returns>The identifier for the StylisticSet16 attached property.</returns>
    public static extern DependencyProperty StylisticSet16Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet16 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet16 property.</param>
    /// <returns>The current value of the StylisticSet16 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet16(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet16 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet16 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet16(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet17 attached property.</summary>
    /// <returns>The identifier for the StylisticSet17 attached property.</returns>
    public static extern DependencyProperty StylisticSet17Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet17 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet17 property.</param>
    /// <returns>The current value of the StylisticSet17 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet17(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet17 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet17 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet17(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet18 attached property.</summary>
    /// <returns>The identifier for the StylisticSet18 attached property.</returns>
    public static extern DependencyProperty StylisticSet18Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet18 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet18 property.</param>
    /// <returns>The current value of the StylisticSet18 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet18(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet18 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet18 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet18(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet19 attached property.</summary>
    /// <returns>The identifier for the StylisticSet19 attached property.</returns>
    public static extern DependencyProperty StylisticSet19Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet19 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet19 property.</param>
    /// <returns>The current value of the StylisticSet19 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet19(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet19 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet19 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet19(DependencyObject element, bool value);

    /// <summary>Identifies the StylisticSet20 attached property.</summary>
    /// <returns>The identifier for the StylisticSet20 attached property.</returns>
    public static extern DependencyProperty StylisticSet20Property { [MethodImpl] get; }

    /// <summary>Returns the value of the StylisticSet20 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the StylisticSet20 property.</param>
    /// <returns>The current value of the StylisticSet20 attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetStylisticSet20(DependencyObject element);

    /// <summary>Sets the value of the StylisticSet20 attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the StylisticSet20 property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetStylisticSet20(DependencyObject element, bool value);

    /// <summary>Identifies the Capitals attached property.</summary>
    /// <returns>The identifier for the Capitals attached property.</returns>
    public static extern DependencyProperty CapitalsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the Capitals attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the Capitals property.</param>
    /// <returns>The current value of the Capitals attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontCapitals GetCapitals(DependencyObject element);

    /// <summary>Sets the value of the Capitals attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the Capitals property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetCapitals(DependencyObject element, FontCapitals value);

    /// <summary>Identifies the CapitalSpacing attached property.</summary>
    /// <returns>The identifier for the CapitalSpacing attached property.</returns>
    public static extern DependencyProperty CapitalSpacingProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the CapitalSpacing attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the CapitalSpacing property.</param>
    /// <returns>The current value of the CapitalSpacing attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetCapitalSpacing(DependencyObject element);

    /// <summary>Sets the value of the CapitalSpacing attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the CapitalSpacing property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetCapitalSpacing(DependencyObject element, bool value);

    /// <summary>Identifies the Kerning attached property.</summary>
    /// <returns>The identifier for the Kerning attached property.</returns>
    public static extern DependencyProperty KerningProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the Kerning attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the Kerning property.</param>
    /// <returns>The current value of the Kerning attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetKerning(DependencyObject element);

    /// <summary>Sets the value of the Kerning attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the Kerning property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetKerning(DependencyObject element, bool value);

    /// <summary>Identifies the CaseSensitiveForms attached property.</summary>
    /// <returns>The identifier for the CaseSensitiveForms attached property.</returns>
    public static extern DependencyProperty CaseSensitiveFormsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the CaseSensitiveForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the CaseSensitiveForms property.</param>
    /// <returns>The current value of the CaseSensitiveForms attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetCaseSensitiveForms(DependencyObject element);

    /// <summary>Sets the value of the CaseSensitiveForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the CaseSensitiveForms property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetCaseSensitiveForms(DependencyObject element, bool value);

    /// <summary>Identifies the HistoricalForms attached property.</summary>
    /// <returns>The identifier for the HistoricalForms attached property.</returns>
    public static extern DependencyProperty HistoricalFormsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the HistoricalForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the HistoricalForms property.</param>
    /// <returns>The current value of the HistoricalForms attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetHistoricalForms(DependencyObject element);

    /// <summary>Sets the value of the HistoricalForms attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the HistoricalForms property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetHistoricalForms(DependencyObject element, bool value);

    /// <summary>Identifies the Fraction attached property.</summary>
    /// <returns>The identifier for the Fraction attached property.</returns>
    public static extern DependencyProperty FractionProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the Fraction attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the Fraction property.</param>
    /// <returns>The current value of the Fraction attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontFraction GetFraction(DependencyObject element);

    /// <summary>Sets the value of the Fraction attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the Fraction property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetFraction(DependencyObject element, FontFraction value);

    /// <summary>Identifies the NumeralStyle attached property.</summary>
    /// <returns>The identifier for the NumeralStyle attached property.</returns>
    public static extern DependencyProperty NumeralStyleProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the NumeralStyle attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the NumeralStyle property.</param>
    /// <returns>The current value of the NumeralStyle attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontNumeralStyle GetNumeralStyle(DependencyObject element);

    /// <summary>Sets the value of the NumeralStyle attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the NumeralStyle property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetNumeralStyle(DependencyObject element, FontNumeralStyle value);

    /// <summary>Identifies the NumeralAlignment attached property.</summary>
    /// <returns>The identifier for the NumeralAlignment attached property.</returns>
    public static extern DependencyProperty NumeralAlignmentProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the NumeralAlignment attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the NumeralAlignment property.</param>
    /// <returns>The current value of the NumeralAlignment attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontNumeralAlignment GetNumeralAlignment(
      DependencyObject element);

    /// <summary>Sets the value of the NumeralAlignment attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the NumeralAlignment property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetNumeralAlignment(
      DependencyObject element,
      FontNumeralAlignment value);

    /// <summary>Identifies the SlashedZero attached property.</summary>
    /// <returns>The identifier for the SlashedZero attached property.</returns>
    public static extern DependencyProperty SlashedZeroProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the SlashedZero attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the SlashedZero property.</param>
    /// <returns>The current value of the SlashedZero attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetSlashedZero(DependencyObject element);

    /// <summary>Sets the value of the SlashedZero attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the SlashedZero property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetSlashedZero(DependencyObject element, bool value);

    /// <summary>Identifies the MathematicalGreek attached property.</summary>
    /// <returns>The identifier for the MathematicalGreek attached property.</returns>
    public static extern DependencyProperty MathematicalGreekProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the MathematicalGreek attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the MathematicalGreek property.</param>
    /// <returns>The current value of the MathematicalGreek attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern bool GetMathematicalGreek(DependencyObject element);

    /// <summary>Sets the value of the MathematicalGreek attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the MathematicalGreek property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetMathematicalGreek(DependencyObject element, bool value);

    /// <summary>Identifies the Variants attached property.</summary>
    /// <returns>The identifier for the Variants attached property.</returns>
    public static extern DependencyProperty VariantsProperty { [MethodImpl] get; }

    /// <summary>Returns the value of the Variants attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to retrieve the value of the Variants property.</param>
    /// <returns>The current value of the Variants attached property on the specified dependency object.</returns>
    [MethodImpl]
    public static extern FontVariants GetVariants(DependencyObject element);

    /// <summary>Sets the value of the Variants attached property for a specified dependency object.</summary>
    /// <param name="element">The dependency object for which to set the value of the Variants property.</param>
    /// <param name="value">The new value to set the property to.</param>
    [MethodImpl]
    public static extern void SetVariants(DependencyObject element, FontVariants value);
  }
}
