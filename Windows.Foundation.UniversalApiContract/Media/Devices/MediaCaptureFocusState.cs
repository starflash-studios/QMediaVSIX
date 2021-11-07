﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaCaptureFocusState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the different focus states the capture device can be in.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCaptureFocusState
  {
    /// <summary>The focus state is uninitialized.</summary>
    Uninitialized,
    /// <summary>The focus has been lost.</summary>
    Lost,
    /// <summary>Searching for focus.</summary>
    Searching,
    /// <summary>Focused.</summary>
    Focused,
    /// <summary>The attempt to focus has failed.</summary>
    Failed,
  }
}