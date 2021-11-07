// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3521858652, 6995, 20042, 139, 92, 219, 120, 135, 172, 148, 155)]
  [ExclusiveTo(typeof (VariablePhotoCapturedEventArgs))]
  internal interface IVariablePhotoCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    TimeSpan CaptureTimeOffset { get; }

    IReference<uint> UsedFrameControllerIndex { get; }

    CapturedFrameControlValues CapturedFrameControlValues { get; }
  }
}
