// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDragItemsStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1909399900, 56045, 18307, 170, 17, 220, 87, 77, 39, 19, 233)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragItemsStartingEventArgs))]
  internal interface IDragItemsStartingEventArgs
  {
    bool Cancel { get; set; }

    IVector<object> Items { get; }

    DataPackage Data { get; }
  }
}
