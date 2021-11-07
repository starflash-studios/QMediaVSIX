// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DragEventArgs))]
  [Guid(3024144323, 692, 18816, 147, 66, 37, 218, 225, 192, 241, 136)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDragEventArgs
  {
    bool Handled { get; set; }

    DataPackage Data { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
