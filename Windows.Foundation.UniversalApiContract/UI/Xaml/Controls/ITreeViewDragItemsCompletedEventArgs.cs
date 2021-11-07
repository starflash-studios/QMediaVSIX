// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewDragItemsCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1017668396, 17169, 22350, 138, 180, 59, 122, 165, 222, 122, 136)]
  [ExclusiveTo(typeof (TreeViewDragItemsCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface ITreeViewDragItemsCompletedEventArgs
  {
    DataPackageOperation DropResult { get; }

    IVectorView<object> Items { get; }
  }
}
