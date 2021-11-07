// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Vector3Transition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides the animated transition behavior when an element's Translation or Scale properties change.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IVector3TransitionFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Vector3Transition : IVector3Transition
  {
    /// <summary>Initializes a new instance of the Vector3Transition class.</summary>
    [MethodImpl]
    public extern Vector3Transition();

    /// <summary>Gets or sets the duration of the transition.</summary>
    /// <returns>The duration of the transition.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether to animate changes in the three subchannels of the Vector3.</summary>
    /// <returns>A value that specifies whether to animate changes in the subchannels of the Vector3.</returns>
    public extern Vector3TransitionComponents Components { [MethodImpl] get; [MethodImpl] set; }
  }
}
