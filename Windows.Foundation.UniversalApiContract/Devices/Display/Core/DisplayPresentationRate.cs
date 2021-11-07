// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayPresentationRate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Display.Core
{
  /// <summary>Describes an overall presentation rate composed of a rational refresh rate and a divider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public struct DisplayPresentationRate
  {
    /// <summary>The refresh rate, also known as vertical sync rate, which controls how often the display pipeline scans out to a target. This rate is represented in Hertz (Hz) and stored as a two-part rational number.</summary>
    public Rational VerticalSyncRate;
    /// <summary>Specifies an integer divider to scale down the rate of full-screen presentations as a fraction of vertical syncs. For example, if **VerticalSyncsPerPresentation** is set to 2, then one full-screen presentation will last for 2 vertical syncs before the next presentation can occur. Support for values other than 1 requires hardware support.</summary>
    public int VerticalSyncsPerPresentation;
  }
}
