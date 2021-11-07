// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIconSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (BitmapIconSource))]
  [WebHostHidden]
  [Guid(1511020679, 58516, 19755, 133, 40, 57, 71, 34, 150, 19, 63)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBitmapIconSourceStatics
  {
    DependencyProperty UriSourceProperty { get; }

    DependencyProperty ShowAsMonochromeProperty { get; }
  }
}
