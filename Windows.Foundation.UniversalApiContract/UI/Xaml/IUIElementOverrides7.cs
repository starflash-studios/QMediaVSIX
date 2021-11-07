// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementOverrides7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [Guid(3112140648, 49819, 19609, 161, 195, 149, 38, 25, 214, 231, 32)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IUIElementOverrides7
  {
    IIterable<DependencyObject> GetChildrenInTabFocusOrder();

    void OnProcessKeyboardAccelerators(ProcessKeyboardAcceleratorEventArgs args);
  }
}
