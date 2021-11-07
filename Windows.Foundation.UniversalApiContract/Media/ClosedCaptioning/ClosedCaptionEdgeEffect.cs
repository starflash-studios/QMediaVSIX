﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.ClosedCaptionEdgeEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ClosedCaptioning
{
  /// <summary>Specifies the edge effect of closed caption text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ClosedCaptionEdgeEffect
  {
    /// <summary>The default edge effect.</summary>
    Default,
    /// <summary>No edge effect.</summary>
    None,
    /// <summary>Raised edge.</summary>
    Raised,
    /// <summary>Depressed edge.</summary>
    Depressed,
    /// <summary>Uniform edge</summary>
    Uniform,
    /// <summary>Drop shadow.</summary>
    DropShadow,
  }
}