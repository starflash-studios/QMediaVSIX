﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEqualizerEffectDefinitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EqualizerEffectDefinition))]
  [Guid(3532091332, 54288, 20149, 158, 105, 201, 170, 18, 119, 234, 240)]
  internal interface IEqualizerEffectDefinitionFactory
  {
    EqualizerEffectDefinition Create(AudioGraph audioGraph);
  }
}