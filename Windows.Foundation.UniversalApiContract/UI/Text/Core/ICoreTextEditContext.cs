// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextEditContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextEditContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3211135151, 16449, 18371, 178, 99, 169, 24, 235, 94, 174, 242)]
  internal interface ICoreTextEditContext
  {
    string Name { get; set; }

    CoreTextInputScope InputScope { get; set; }

    bool IsReadOnly { get; set; }

    CoreTextInputPaneDisplayPolicy InputPaneDisplayPolicy { get; set; }

    event TypedEventHandler<CoreTextEditContext, CoreTextTextRequestedEventArgs> TextRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextSelectionRequestedEventArgs> SelectionRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextLayoutRequestedEventArgs> LayoutRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextTextUpdatingEventArgs> TextUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextSelectionUpdatingEventArgs> SelectionUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextFormatUpdatingEventArgs> FormatUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextCompositionStartedEventArgs> CompositionStarted;

    event TypedEventHandler<CoreTextEditContext, CoreTextCompositionCompletedEventArgs> CompositionCompleted;

    event TypedEventHandler<CoreTextEditContext, object> FocusRemoved;

    void NotifyFocusEnter();

    void NotifyFocusLeave();

    void NotifyTextChanged(CoreTextRange modifiedRange, int newLength, CoreTextRange newSelection);

    void NotifySelectionChanged(CoreTextRange selection);

    void NotifyLayoutChanged();
  }
}
