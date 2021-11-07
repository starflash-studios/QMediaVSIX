// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Window))]
  [Guid(846599805, 51702, 17965, 157, 226, 174, 76, 31, 216, 194, 229)]
  [WebHostHidden]
  internal interface IWindow
  {
    Rect Bounds { get; }

    bool Visible { get; }

    UIElement Content { get; set; }

    CoreWindow CoreWindow { get; }

    CoreDispatcher Dispatcher { get; }

    event WindowActivatedEventHandler Activated;

    event WindowClosedEventHandler Closed;

    event WindowSizeChangedEventHandler SizeChanged;

    event WindowVisibilityChangedEventHandler VisibilityChanged;

    void Activate();

    void Close();
  }
}
