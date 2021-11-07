// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositorDefinitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(1130822928, 26808, 19794, 137, 182, 2, 169, 104, 204, 168, 153)]
  [ExclusiveTo(typeof (VideoCompositorDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoCompositorDefinitionFactory
  {
    VideoCompositorDefinition Create(string activatableClassId);

    VideoCompositorDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
