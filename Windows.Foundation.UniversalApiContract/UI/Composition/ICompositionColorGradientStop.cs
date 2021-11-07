// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionColorGradientStop
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionColorGradientStop))]
  [Guid(1862322834, 51201, 20033, 154, 143, 165, 62, 32, 245, 119, 120)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface ICompositionColorGradientStop
  {
    Color Color { get; set; }

    float Offset { get; set; }
  }
}
