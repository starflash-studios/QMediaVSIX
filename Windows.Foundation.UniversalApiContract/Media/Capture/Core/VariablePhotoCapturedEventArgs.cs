// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  /// <summary>Provides data for the PhotoCaptured event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class VariablePhotoCapturedEventArgs : IVariablePhotoCapturedEventArgs
  {
    /// <summary>Gets a CapturedFrame object representing a captured frame of a variable photo sequence.</summary>
    /// <returns>A CapturedFrame object representing a captured frame of a variable photo sequence.</returns>
    public extern CapturedFrame Frame { [MethodImpl] get; }

    /// <summary>Gets the time offset of the capture of the associated frame in a variable photo sequence.</summary>
    /// <returns>The time offset of the capture of the associated frame in a variable photo sequence.</returns>
    public extern TimeSpan CaptureTimeOffset { [MethodImpl] get; }

    /// <summary>Gets an index value that indicates which element of the DesiredFrameControllers vector was used to specify the requested control values for the associated frame of a variable photo sequence.</summary>
    /// <returns>An index value that indicates which element of the DesiredFrameControllers vector was used to specify the requested control values for the associated frame of a variable photo sequence.</returns>
    public extern IReference<uint> UsedFrameControllerIndex { [MethodImpl] get; }

    /// <summary>Gets a CapturedFrameControlValues object that indicates the capture settings used for the associated frame in a variable photo sequence.</summary>
    /// <returns>A CapturedFrameControlValues object that indicates the capture settings used for the associated frame in a variable photo sequence.</returns>
    public extern CapturedFrameControlValues CapturedFrameControlValues { [MethodImpl] get; }
  }
}
