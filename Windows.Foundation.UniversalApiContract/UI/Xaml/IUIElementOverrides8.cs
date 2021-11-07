// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementOverrides8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [Guid(1247437916, 21645, 18639, 185, 152, 120, 68, 214, 226, 53, 161)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  internal interface IUIElementOverrides8
  {
    void OnKeyboardAcceleratorInvoked(KeyboardAcceleratorInvokedEventArgs args);

    void OnBringIntoViewRequested(BringIntoViewRequestedEventArgs e);
  }
}
