// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  [Guid(3515951089, 14516, 20129, 143, 51, 132, 150, 41, 164, 201, 193)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IXamlCompositionBrushBaseOverrides
  {
    void OnConnected();

    void OnDisconnected();
  }
}
