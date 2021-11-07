// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialGestureRecognizerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(1998668166, 22457, 12624, 131, 130, 105, 139, 36, 226, 100, 208)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialGestureRecognizer))]
  internal interface ISpatialGestureRecognizerFactory
  {
    SpatialGestureRecognizer Create(SpatialGestureSettings settings);
  }
}
