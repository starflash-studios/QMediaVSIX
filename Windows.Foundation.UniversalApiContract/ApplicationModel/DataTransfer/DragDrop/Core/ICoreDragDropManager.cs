// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragDropManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [Guid(2102842180, 33892, 20399, 170, 73, 55, 234, 110, 45, 123, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreDragDropManager))]
  internal interface ICoreDragDropManager
  {
    event TypedEventHandler<CoreDragDropManager, CoreDropOperationTargetRequestedEventArgs> TargetRequested;

    bool AreConcurrentOperationsEnabled { get; set; }
  }
}
