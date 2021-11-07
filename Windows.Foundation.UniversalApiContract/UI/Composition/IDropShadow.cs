// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDropShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (DropShadow))]
  [Guid(3415702535, 41300, 18513, 133, 231, 168, 146, 76, 132, 250, 216)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IDropShadow
  {
    float BlurRadius { get; set; }

    Color Color { get; set; }

    CompositionBrush Mask { get; set; }

    Vector3 Offset { get; set; }

    float Opacity { get; set; }
  }
}
