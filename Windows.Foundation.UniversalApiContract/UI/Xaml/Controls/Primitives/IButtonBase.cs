// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IButtonBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ButtonBase))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4194315290, 18766, 18127, 145, 212, 225, 74, 141, 121, 134, 116)]
  internal interface IButtonBase
  {
    ClickMode ClickMode { get; set; }

    bool IsPointerOver { get; }

    bool IsPressed { get; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    event RoutedEventHandler Click;
  }
}
