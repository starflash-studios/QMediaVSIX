// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BasicConnectedAnimationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>An object that configures the connected animation as a linear transition from the source to the destination.</summary>
  [WebHostHidden]
  [Composable(typeof (IBasicConnectedAnimationConfigurationFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public class BasicConnectedAnimationConfiguration : 
    ConnectedAnimationConfiguration,
    IBasicConnectedAnimationConfiguration
  {
    /// <summary>Initializes a new instance of the BasicConnectedAnimationConfiguration class.</summary>
    [MethodImpl]
    public extern BasicConnectedAnimationConfiguration();
  }
}
