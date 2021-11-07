// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaTransportControlsHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1517756487, 43425, 17957, 146, 112, 127, 73, 135, 93, 67, 148)]
  internal interface IMediaTransportControlsHelperStatics
  {
    DependencyProperty DropoutOrderProperty { get; }

    IReference<int> GetDropoutOrder(UIElement element);

    void SetDropoutOrder(UIElement element, IReference<int> value);
  }
}
