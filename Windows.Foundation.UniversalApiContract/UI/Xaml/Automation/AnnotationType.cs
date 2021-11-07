// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AnnotationType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Provides a set of constants that identify types of annotations in a document, as used by the ISpreadsheetItemProvider  Microsoft UI Automation interface.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AnnotationType
  {
    /// <summary>The annotation type is unknown.</summary>
    Unknown = 60000, // 0x0000EA60
    /// <summary>A spelling error, often denoted by a red squiggly line.</summary>
    SpellingError = 60001, // 0x0000EA61
    /// <summary>A grammatical error, often denoted by a green squiggly line.</summary>
    GrammarError = 60002, // 0x0000EA62
    /// <summary>A comment. Comments can take different forms depending on the application.</summary>
    Comment = 60003, // 0x0000EA63
    /// <summary>An error in a formula. Formula errors typically include red text and exclamation marks.</summary>
    FormulaError = 60004, // 0x0000EA64
    /// <summary>A change that was made to the document.</summary>
    TrackChanges = 60005, // 0x0000EA65
    /// <summary>The header for a page in a document.</summary>
    Header = 60006, // 0x0000EA66
    /// <summary>The footer for a page in a document.</summary>
    Footer = 60007, // 0x0000EA67
    /// <summary>Highlighted content, typically denoted by a contrasting background color.</summary>
    Highlighted = 60008, // 0x0000EA68
    /// <summary>Endnote content.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Endnote = 60009, // 0x0000EA69
    /// <summary>Footnote content.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Footnote = 60010, // 0x0000EA6A
    /// <summary>An insertion change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] InsertionChange = 60011, // 0x0000EA6B
    /// <summary>A deletion change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeletionChange = 60012, // 0x0000EA6C
    /// <summary>A move change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] MoveChange = 60013, // 0x0000EA6D
    /// <summary>A format change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] FormatChange = 60014, // 0x0000EA6E
    /// <summary>An unsynced change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UnsyncedChange = 60015, // 0x0000EA6F
    /// <summary>An editing locked change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EditingLockedChange = 60016, // 0x0000EA70
    /// <summary>An external change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ExternalChange = 60017, // 0x0000EA71
    /// <summary>A conflicting change.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ConflictingChange = 60018, // 0x0000EA72
    /// <summary>Author info.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Author = 60019, // 0x0000EA73
    /// <summary>An advanced proofing issue.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AdvancedProofingIssue = 60020, // 0x0000EA74
    /// <summary>A data validation error.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DataValidationError = 60021, // 0x0000EA75
    /// <summary>A circular reference error.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CircularReferenceError = 60022, // 0x0000EA76
  }
}
