// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3370335687, 54446, 19079, 148, 127, 172, 77, 11, 207, 90, 244)]
  [ExclusiveTo(typeof (BitmapIconSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBitmapIconSource
  {
    Uri UriSource { get; set; }

    bool ShowAsMonochrome { get; set; }
  }
}
