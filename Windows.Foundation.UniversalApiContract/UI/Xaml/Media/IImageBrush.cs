// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IImageBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ImageBrush))]
  [WebHostHidden]
  [Guid(2681279351, 49450, 17555, 191, 125, 243, 168, 173, 116, 181, 84)]
  internal interface IImageBrush
  {
    ImageSource ImageSource { get; set; }

    event ExceptionRoutedEventHandler ImageFailed;

    event RoutedEventHandler ImageOpened;
  }
}
