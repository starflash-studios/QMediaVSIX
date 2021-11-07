﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterShapeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies the shape of an AudioNodeEmitterShape object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AudioNodeEmitterShapeKind
  {
    /// <summary>The shape is omnidirectional.</summary>
    Omnidirectional,
    /// <summary>The shape is a cone.</summary>
    Cone,
  }
}