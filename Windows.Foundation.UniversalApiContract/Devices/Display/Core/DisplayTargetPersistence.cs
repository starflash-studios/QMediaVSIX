// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayTargetPersistence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify how a monitor connected to a target should be virtually persisted when the hardware no longer reports any connected monitor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayTargetPersistence
  {
    /// <summary>Specifies no persistence.</summary>
    None,
    /// <summary>Specifies persistence until reboot.</summary>
    BootPersisted,
    /// <summary>Specifies temporary persistence.</summary>
    TemporaryPersisted,
    /// <summary>Specifies persistence via a path.</summary>
    PathPersisted,
  }
}
