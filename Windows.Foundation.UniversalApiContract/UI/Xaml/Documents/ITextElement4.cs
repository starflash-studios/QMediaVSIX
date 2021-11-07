// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (TextElement))]
  [Guid(2979455522, 51726, 18601, 131, 188, 54, 206, 80, 86, 106, 199)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface ITextElement4
  {
    TextDecorations TextDecorations { get; set; }

    bool IsAccessKeyScope { get; set; }

    DependencyObject AccessKeyScopeOwner { get; set; }

    KeyTipPlacementMode KeyTipPlacementMode { get; set; }

    double KeyTipHorizontalOffset { get; set; }

    double KeyTipVerticalOffset { get; set; }

    event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;
  }
}
