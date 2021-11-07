// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GameControllerVersionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Contains information on the game controller version.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct GameControllerVersionInfo
  {
    /// <summary>Major version number.</summary>
    public ushort Major;
    /// <summary>Minor version number.</summary>
    public ushort Minor;
    /// <summary>Build number.</summary>
    public ushort Build;
    /// <summary>Revison number.</summary>
    public ushort Revision;
  }
}
