// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ArcadeStickReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>The current state of the arcade stick.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct ArcadeStickReading
  {
    /// <summary>Time when the state was retrieved from the arcade stick.</summary>
    public ulong Timestamp;
    /// <summary>The state of the arcade stick's buttons.</summary>
    public ArcadeStickButtons Buttons;
  }
}
