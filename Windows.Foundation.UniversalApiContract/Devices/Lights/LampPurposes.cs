// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.LampPurposes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  /// <summary>Purpose/s of a lamp.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Flags]
  public enum LampPurposes : uint
  {
    /// <summary>No Purposes defined for this lamp.</summary>
    Undefined = 0,
    /// <summary>Control Lamp (for example, button/key/slider)</summary>
    Control = 1,
    /// <summary>Accent Lamp that doesn't interact with the user (for example, case fan LED, illuminated side panels on a keyboard).</summary>
    Accent = 2,
    /// <summary>Device branding (for example, manufacturer logo).</summary>
    Branding = 4,
    /// <summary>Status lamp (for example, unread email, CPU temperature).</summary>
    Status = 8,
    /// <summary>Illuminates an object that is outside of the LampArray (for example, stage spotlight, car headlights, camera flash).</summary>
    Illumination = 16, // 0x00000010
    /// <summary>A lamp the user directly looks at (for example, within an artwork or costume).</summary>
    Presentation = 32, // 0x00000020
  }
}
