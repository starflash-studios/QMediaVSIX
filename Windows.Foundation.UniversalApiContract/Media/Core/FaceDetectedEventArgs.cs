// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the FaceDetected event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class FaceDetectedEventArgs : IFaceDetectedEventArgs
  {
    /// <summary>Gets the FaceDetectionEffectFrame associated with a FaceDetected event.</summary>
    /// <returns>The FaceDetectionEffectFrame associated with a FaceDetected event.</returns>
    public extern FaceDetectionEffectFrame ResultFrame { [MethodImpl] get; }
  }
}
