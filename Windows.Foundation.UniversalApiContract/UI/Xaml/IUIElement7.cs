// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [Guid(3405531496, 25449, 16969, 128, 249, 61, 101, 99, 25, 232, 17)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  internal interface IUIElement7
  {
    IVector<KeyboardAccelerator> KeyboardAccelerators { get; }

    event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> CharacterReceived;

    event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> ProcessKeyboardAccelerators;

    event KeyEventHandler PreviewKeyDown;

    event KeyEventHandler PreviewKeyUp;

    void TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args);
  }
}
