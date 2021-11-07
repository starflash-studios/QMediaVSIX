// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.IAdaptiveCard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  /// <summary>An Adaptive Card that can be used in Windows.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1926256268, 41588, 16845, 130, 168, 152, 157, 64, 185, 176, 94)]
  public interface IAdaptiveCard
  {
    /// <summary>Returns the JSON that represents this Adaptive Card.</summary>
    /// <returns>A String that contains the JSON representation of the Adaptive Card.</returns>
    string ToJson();
  }
}
