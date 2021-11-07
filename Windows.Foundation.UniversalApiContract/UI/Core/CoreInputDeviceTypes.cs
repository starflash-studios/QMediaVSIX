// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreInputDeviceTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies user input modalities. These values can be combined.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum CoreInputDeviceTypes : uint
  {
    /// <summary>No input.</summary>
    None = 0,
    /// <summary>Expose touch input events.</summary>
    Touch = 1,
    /// <summary>Expose pen input events.</summary>
    Pen = 2,
    /// <summary>Expose mouse input events.</summary>
    Mouse = 4,
  }
}
