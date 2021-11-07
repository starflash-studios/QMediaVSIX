// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIconSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapIconSource))]
  [Guid(1695147462, 17590, 19665, 134, 205, 195, 24, 155, 18, 196, 60)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBitmapIconSourceFactory
  {
    BitmapIconSource CreateInstance(object baseInterface, out object innerInterface);
  }
}
