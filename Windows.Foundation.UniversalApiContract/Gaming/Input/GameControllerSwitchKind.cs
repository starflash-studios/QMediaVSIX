// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GameControllerSwitchKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>The type of switch on the game controller.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GameControllerSwitchKind
  {
    /// <summary>A two-way switch, which has **Up**, **Down**, and **Center** positions.</summary>
    TwoWay,
    /// <summary>A four-way switch, which has **Up**, **Down**, **Left**, **Right**, and **Center** positions.</summary>
    FourWay,
    /// <summary>An eight-way switch, which has all positions in the **GameControllerSwitchPosition** enumeration.</summary>
    EightWay,
  }
}
