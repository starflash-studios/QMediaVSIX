// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3052051817, 46344, 20124, 189, 39, 107, 4, 75, 95, 120, 160)]
  [WebHostHidden]
  [ExclusiveTo(typeof (XamlLight))]
  internal interface IXamlLightStatics
  {
    void AddTargetElement(string lightId, UIElement element);

    void RemoveTargetElement(string lightId, UIElement element);

    void AddTargetBrush(string lightId, Brush brush);

    void RemoveTargetBrush(string lightId, Brush brush);
  }
}
