// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichEditBox))]
  [WebHostHidden]
  [Guid(2426763840, 32950, 20430, 177, 236, 227, 198, 22, 40, 75, 106)]
  internal interface IRichEditBox
  {
    bool IsReadOnly { get; set; }

    bool AcceptsReturn { get; set; }

    TextAlignment TextAlignment { get; set; }

    TextWrapping TextWrapping { get; set; }

    bool IsSpellCheckEnabled { get; set; }

    bool IsTextPredictionEnabled { get; set; }

    ITextDocument Document { get; }

    InputScope InputScope { get; set; }

    event RoutedEventHandler TextChanged;

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;
  }
}
