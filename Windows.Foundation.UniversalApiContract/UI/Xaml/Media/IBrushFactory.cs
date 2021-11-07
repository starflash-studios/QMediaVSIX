// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (Brush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(966154402, 5371, 19343, 131, 230, 110, 61, 171, 18, 6, 155)]
  [WebHostHidden]
  internal interface IBrushFactory
  {
    Brush CreateInstance(object baseInterface, out object innerInterface);
  }
}
