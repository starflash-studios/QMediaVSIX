// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.LinearPointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates from the Point value of the previous key frame to its own Value, using linear interpolation.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class LinearPointKeyFrame : PointKeyFrame, ILinearPointKeyFrame
  {
    /// <summary>Initializes a new instance of the LinearPointKeyFrame class.</summary>
    [MethodImpl]
    public extern LinearPointKeyFrame();
  }
}
