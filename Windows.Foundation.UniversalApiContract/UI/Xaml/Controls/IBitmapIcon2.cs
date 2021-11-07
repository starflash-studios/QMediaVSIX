// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIcon2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(103064074, 40401, 16897, 187, 32, 66, 134, 61, 161, 86, 88)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapIcon))]
  internal interface IBitmapIcon2
  {
    bool ShowAsMonochrome { get; set; }
  }
}
