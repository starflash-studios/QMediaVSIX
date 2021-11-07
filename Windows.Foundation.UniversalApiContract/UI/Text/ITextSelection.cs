// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextSelection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Represents the currently selected text of a document.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2798872356, 62095, 17162, 178, 207, 195, 67, 103, 30, 192, 233)]
  public interface ITextSelection : ITextRange
  {
    /// <summary>Gets and sets text selection options.</summary>
    /// <returns>The text selection options. Each option is binary, so if a particular option is not set, the text selection has the opposite option. For example, if the Overtype option is not set, the text selection is set to insert mode.</returns>
    SelectionOptions Options { get; set; }

    /// <summary>Retrieves the type of text selection.</summary>
    /// <returns>The selection type.</returns>
    SelectionType Type { get; }

    /// <summary>Moves the insertion point or the active end of the text selection to the end of the specified unit, mimicking the functionality of the End key.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units that the insertion point or the active end is moved.</returns>
    int EndKey(TextRangeUnit unit, bool extend);

    /// <summary>Moves the insertion point or the active end of the text selection to the home position, mimicking the functionality of the Home key.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units that the insertion point or the active end is moved.</returns>
    int HomeKey(TextRangeUnit unit, bool extend);

    /// <summary>Moves the insertion point or the active end of the text selection down, mimicking the functionality of the Down Arrow or Page Down key.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid.&lt;table&gt;</param>
    /// <param name="count">The number of units to move. The default value is 1.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units that the insertion point or active end moved down. Collapsing the selection counts as one unit.</returns>
    int MoveDown(TextRangeUnit unit, int count, bool extend);

    /// <summary>Moves the insertion point or the active end of the text selection to the left, mimicking the functionality of the Left Arrow key.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid. &lt;table&gt;</param>
    /// <param name="count">The number of units to move. The default value is 1. If *count* is less than zero, movement is to the right.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units that the insertion point or active end moved. Collapsing the selection counts as one unit.</returns>
    int MoveLeft(TextRangeUnit unit, int count, bool extend);

    /// <summary>Moves the insertion point or the active end of the text selection to the right, mimicking the functionality of the Right Arrow key.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid. &lt;table&gt;</param>
    /// <param name="count">The number of units to move. The default value is 1. If *count* is less than zero, movement is to the left.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units that the insertion point or active end moved. Collapsing the selection counts as one unit.</returns>
    int MoveRight(TextRangeUnit unit, int count, bool extend);

    /// <summary>Moves the insertion point or the active end of the text selection up, mimicking the functionality of the Up Arrow or Page Up keys.</summary>
    /// <param name="unit">The units by which to move the insertion point or active end. The following values are valid.&lt;table&gt;</param>
    /// <param name="count">The number of units to move. The default value is 1.</param>
    /// <param name="extend">Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.</param>
    /// <returns>The number of units the insertion point or active end is moved down. Collapsing the selection counts as one unit.</returns>
    int MoveUp(TextRangeUnit unit, int count, bool extend);

    /// <summary>Enters text into the selection as if someone typed it.</summary>
    /// <param name="value">The text string to type into this selection.</param>
    void TypeText(string value);
  }
}
