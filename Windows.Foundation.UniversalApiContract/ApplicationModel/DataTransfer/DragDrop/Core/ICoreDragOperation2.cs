// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragOperation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ExclusiveTo(typeof (CoreDragOperation))]
  [Guid(2185961004, 55706, 20419, 133, 7, 108, 24, 47, 51, 180, 106)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICoreDragOperation2 : ICoreDragOperation
  {
    DataPackageOperation AllowedOperations { get; set; }
  }
}
