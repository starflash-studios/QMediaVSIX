// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(1744884730, 37048, 18169, 142, 48, 90, 194, 95, 115, 240, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragStartingEventArgs))]
  internal interface IDragStartingEventArgs
  {
    bool Cancel { get; set; }

    DataPackage Data { get; }

    DragUI DragUI { get; }

    DragOperationDeferral GetDeferral();

    Point GetPosition(UIElement relativeTo);
  }
}
