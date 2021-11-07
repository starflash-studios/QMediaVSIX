// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DirectConnectedAnimationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>An object that configures the connected animation to play a quick linear animation between source and destination.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IDirectConnectedAnimationConfigurationFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class DirectConnectedAnimationConfiguration : 
    ConnectedAnimationConfiguration,
    IDirectConnectedAnimationConfiguration
  {
    /// <summary>Initializes a new instance of the DirectConnectedAnimationConfiguration class.</summary>
    [MethodImpl]
    public extern DirectConnectedAnimationConfiguration();
  }
}
