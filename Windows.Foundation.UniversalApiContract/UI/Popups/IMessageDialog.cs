// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IMessageDialog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ExclusiveTo(typeof (MessageDialog))]
  [Guid(871734017, 21285, 17323, 154, 179, 189, 174, 68, 14, 65, 33)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMessageDialog
  {
    string Title { get; set; }

    IVector<IUICommand> Commands { get; }

    uint DefaultCommandIndex { get; set; }

    uint CancelCommandIndex { get; set; }

    string Content { get; set; }

    IAsyncOperation<IUICommand> ShowAsync();

    MessageDialogOptions Options { get; set; }
  }
}
