﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.PowerlineFrequency
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies the local power line frequency.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PowerlineFrequency
  {
    /// <summary>Power-line frequency control is disabled.</summary>
    Disabled,
    /// <summary>The power-line frequency is 50 Hz.</summary>
    FiftyHertz,
    /// <summary>The power-line frequency is 60 Hz.</summary>
    SixtyHertz,
    /// <summary>The power-line frequency is determined automatically by the system.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Auto,
  }
}