// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.GravityConnectedAnimationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>An object that configures the connected animation to play using the gravity configuration.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IGravityConnectedAnimationConfigurationFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class GravityConnectedAnimationConfiguration : 
    ConnectedAnimationConfiguration,
    IGravityConnectedAnimationConfiguration,
    IGravityConnectedAnimationConfiguration2
  {
    /// <summary>Initializes a new instance of the GravityConnectedAnimationConfiguration class.</summary>
    [MethodImpl]
    public extern GravityConnectedAnimationConfiguration();

    /// <summary>Gets or sets a value that indicates whether a shadow effect is shown.</summary>
    /// <returns>**true** if a shadow effect is shown; otherwise, **false**.</returns>
    public extern bool IsShadowEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
