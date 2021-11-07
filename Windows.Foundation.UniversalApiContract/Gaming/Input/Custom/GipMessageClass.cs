// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipMessageClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>The class of a Gip message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum GipMessageClass
  {
    /// <summary>A command message.</summary>
    Command,
    /// <summary>A low latency message.</summary>
    LowLatency,
    /// <summary>A standard latency message.</summary>
    StandardLatency,
  }
}
