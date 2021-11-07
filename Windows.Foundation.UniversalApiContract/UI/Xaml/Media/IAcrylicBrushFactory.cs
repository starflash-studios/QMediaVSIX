// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IAcrylicBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2174952808, 63180, 16403, 131, 99, 146, 138, 226, 59, 122, 97)]
  [ExclusiveTo(typeof (AcrylicBrush))]
  internal interface IAcrylicBrushFactory
  {
    AcrylicBrush CreateInstance(object baseInterface, out object innerInterface);
  }
}
