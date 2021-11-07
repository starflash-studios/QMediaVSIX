﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DiscretePointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates from the Point value of the previous key frame to its own Value using discrete frames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DiscretePointKeyFrame : PointKeyFrame, IDiscretePointKeyFrame
  {
    /// <summary>Initializes a new instance of the DiscretePointKeyFrame class.</summary>
    [MethodImpl]
    public extern DiscretePointKeyFrame();
  }
}