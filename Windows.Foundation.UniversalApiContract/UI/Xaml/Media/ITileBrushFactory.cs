// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITileBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2853543804, 60778, 20403, 176, 20, 181, 199, 227, 121, 164, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TileBrush))]
  internal interface ITileBrushFactory
  {
    TileBrush CreateInstance(object baseInterface, out object innerInterface);
  }
}
