// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DiscreteDoubleKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates from the Double value of the previous key frame to its own Value using discrete values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DiscreteDoubleKeyFrame : DoubleKeyFrame, IDiscreteDoubleKeyFrame
  {
    /// <summary>Initializes a new instance of the DiscreteDoubleKeyFrame class.</summary>
    [MethodImpl]
    public extern DiscreteDoubleKeyFrame();
  }
}
