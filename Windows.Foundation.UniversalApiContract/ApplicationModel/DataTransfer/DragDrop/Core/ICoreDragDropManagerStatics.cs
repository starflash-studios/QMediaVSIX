﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragDropManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreDragDropManager))]
  [Guid(2504195530, 55826, 19484, 141, 6, 4, 29, 178, 151, 51, 195)]
  internal interface ICoreDragDropManagerStatics
  {
    CoreDragDropManager GetForCurrentView();
  }
}