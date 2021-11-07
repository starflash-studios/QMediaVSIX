// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (FaceDetectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(428966950, 50779, 18106, 133, 248, 19, 136, 5, 118, 201, 10)]
  internal interface IFaceDetectedEventArgs
  {
    FaceDetectionEffectFrame ResultFrame { get; }
  }
}
