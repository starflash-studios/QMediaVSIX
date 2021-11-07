// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDistantLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (DistantLight))]
  [Guid(831322876, 23779, 19285, 171, 93, 7, 160, 3, 83, 172, 153)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IDistantLight
  {
    Color Color { get; set; }

    Visual CoordinateSpace { get; set; }

    Vector3 Direction { get; set; }
  }
}
