// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.DragDrop;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(640902744, 10519, 16669, 191, 195, 47, 34, 71, 28, 187, 231)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragEventArgs))]
  internal interface IDragEventArgs2
  {
    DataPackageView DataView { get; }

    DragUIOverride DragUIOverride { get; }

    DragDropModifiers Modifiers { get; }

    DataPackageOperation AcceptedOperation { get; set; }

    DragOperationDeferral GetDeferral();
  }
}
