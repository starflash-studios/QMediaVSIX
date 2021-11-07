// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectionEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(2920672210, 1346, 17065, 188, 144, 242, 131, 162, 159, 70, 193)]
  [ExclusiveTo(typeof (FaceDetectionEffect))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFaceDetectionEffect : IMediaExtension
  {
    bool Enabled { set; get; }

    TimeSpan DesiredDetectionInterval { set; get; }

    event TypedEventHandler<FaceDetectionEffect, FaceDetectedEventArgs> FaceDetected;
  }
}
