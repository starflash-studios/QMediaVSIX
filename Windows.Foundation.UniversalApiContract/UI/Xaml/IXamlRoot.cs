// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IXamlRoot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (XamlRoot))]
  [WebHostHidden]
  [Guid(884279126, 5782, 23405, 142, 155, 199, 20, 100, 204, 173, 90)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IXamlRoot
  {
    UIElement Content { get; }

    Size Size { get; }

    double RasterizationScale { get; }

    bool IsHostVisible { get; }

    UIContext UIContext { get; }

    event TypedEventHandler<XamlRoot, XamlRootChangedEventArgs> Changed;
  }
}
