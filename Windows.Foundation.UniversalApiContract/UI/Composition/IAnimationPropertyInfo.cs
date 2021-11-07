// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAnimationPropertyInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AnimationPropertyInfo))]
  [Guid(4101074693, 60791, 20028, 179, 40, 92, 57, 133, 179, 115, 143)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAnimationPropertyInfo
  {
    AnimationPropertyAccessMode AccessMode { get; set; }
  }
}
