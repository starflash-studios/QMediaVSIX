// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapImage))]
  [Guid(3373476216, 18448, 20062, 128, 135, 3, 103, 30, 230, 13, 133)]
  internal interface IBitmapImageFactory
  {
    BitmapImage CreateInstanceWithUriSource(Uri uriSource);
  }
}
