// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDragItemsCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2936402479, 40568, 19233, 154, 142, 65, 194, 209, 54, 122, 42)]
  [ExclusiveTo(typeof (DragItemsCompletedEventArgs))]
  internal interface IDragItemsCompletedEventArgs
  {
    IVectorView<object> Items { get; }

    DataPackageOperation DropResult { get; }
  }
}
