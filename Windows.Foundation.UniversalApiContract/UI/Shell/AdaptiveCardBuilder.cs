// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.AdaptiveCardBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  /// <summary>Builds Adaptive Cards that can be used in Windows.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (IAdaptiveCardBuilderStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class AdaptiveCardBuilder
  {
    /// <summary>Creates a new instance of IAdaptiveCard using the specified Adaptive Card JSON. For more information, see Get Started with Adaptive Cards.</summary>
    /// <param name="value">A String representation of the JSON that describes the Adaptive Card to create.</param>
    /// <returns>An IAdaptiveCard object that represents the described Adaptive Card.</returns>
    [MethodImpl]
    public static extern IAdaptiveCard CreateAdaptiveCardFromJson(string value);
  }
}
