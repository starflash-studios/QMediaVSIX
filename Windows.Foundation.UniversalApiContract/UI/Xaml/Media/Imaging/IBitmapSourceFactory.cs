// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapSource))]
  [Guid(3795862030, 54439, 18852, 160, 180, 165, 159, 221, 119, 229, 8)]
  internal interface IBitmapSourceFactory
  {
    BitmapSource CreateInstance(object baseInterface, out object innerInterface);
  }
}
