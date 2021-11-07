// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IXamlUICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (XamlUICommand))]
  [WebHostHidden]
  [Guid(2224355540, 60113, 24321, 173, 46, 168, 202, 212, 249, 220, 14)]
  internal interface IXamlUICommand
  {
    string Label { get; set; }

    IconSource IconSource { get; set; }

    IVector<KeyboardAccelerator> KeyboardAccelerators { get; }

    string AccessKey { get; set; }

    string Description { get; set; }

    ICommand Command { get; set; }

    event TypedEventHandler<XamlUICommand, ExecuteRequestedEventArgs> ExecuteRequested;

    event TypedEventHandler<XamlUICommand, CanExecuteRequestedEventArgs> CanExecuteRequested;

    void NotifyCanExecuteChanged();
  }
}
