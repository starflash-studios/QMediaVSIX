// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.IAdaptiveCardBuilderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  /// <summary>Provides access to methods that build Adaptive Cards for use on Windows.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1986891528, 54270, 17223, 160, 188, 185, 234, 154, 109, 194, 142)]
  public interface IAdaptiveCardBuilderStatics
  {
    /// <summary>Creates a new instance of IAdaptiveCard using the specified Adaptive Card JSON. For more information, see Get Started with Adaptive Cards.</summary>
    /// <param name="value">A String representation of the JSON that describes the Adaptive Card to create.</param>
    /// <returns>An IAdapativeCard object that represents the described Adaptive Card.</returns>
    IAdaptiveCard CreateAdaptiveCardFromJson(string value);
  }
}
