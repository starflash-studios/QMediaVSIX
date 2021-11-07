// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISolidColorBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SolidColorBrush))]
  [Guid(3644182028, 34549, 19878, 138, 39, 177, 97, 158, 247, 249, 43)]
  internal interface ISolidColorBrushFactory
  {
    SolidColorBrush CreateInstanceWithColor(Color color);
  }
}
