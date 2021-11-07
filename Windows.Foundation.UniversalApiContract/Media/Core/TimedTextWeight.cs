﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextWeight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the weight of timed text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedTextWeight
  {
    /// <summary>The text is normal weight.</summary>
    Normal = 400, // 0x00000190
    /// <summary>The text is bold.</summary>
    Bold = 700, // 0x000002BC
  }
}