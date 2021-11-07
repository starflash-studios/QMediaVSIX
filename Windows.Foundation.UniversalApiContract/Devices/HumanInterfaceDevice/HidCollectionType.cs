// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidCollectionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Identifies the relationship that defines a grouping of controls on the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HidCollectionType
  {
    /// <summary>The controls are related by physical source.</summary>
    Physical,
    /// <summary>The controls are related by intended application.</summary>
    Application,
    /// <summary>The controls are logically related.</summary>
    Logical,
    /// <summary>The controls are related by report type.</summary>
    Report,
    /// <summary>The controls are related by a named array.</summary>
    NamedArray,
    /// <summary>The controls are related by a usage switch.</summary>
    UsageSwitch,
    /// <summary>The controls are related by a usage modifier.</summary>
    UsageModifier,
    /// <summary>The control relationship is not described by a defined category.</summary>
    Other,
  }
}
