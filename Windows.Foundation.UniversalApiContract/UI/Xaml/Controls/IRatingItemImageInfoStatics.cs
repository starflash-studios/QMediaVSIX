// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemImageInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2218281067, 19228, 16675, 186, 11, 115, 72, 77, 104, 195, 56)]
  [ExclusiveTo(typeof (RatingItemImageInfo))]
  internal interface IRatingItemImageInfoStatics
  {
    DependencyProperty DisabledImageProperty { get; }

    DependencyProperty ImageProperty { get; }

    DependencyProperty PlaceholderImageProperty { get; }

    DependencyProperty PointerOverImageProperty { get; }

    DependencyProperty PointerOverPlaceholderImageProperty { get; }

    DependencyProperty UnsetImageProperty { get; }
  }
}
