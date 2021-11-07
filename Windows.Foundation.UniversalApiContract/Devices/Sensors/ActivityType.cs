// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivityType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Specifies activity types of a sensor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ActivityType
  {
    /// <summary>The sensor indicates an unknown activity.</summary>
    Unknown,
    /// <summary>The sensor indicates it is active but in an idle state. It is not with the user and remaining still such as resting on a table.</summary>
    Idle,
    /// <summary>The sensor indicates that it's not moving.</summary>
    Stationary,
    /// <summary>The sensor indicates that it making minor movements while the user is stationary.</summary>
    Fidgeting,
    /// <summary>The sensor indicates the user is walking. The user travels at a moderate pace with one foot on the ground at all times.</summary>
    Walking,
    /// <summary>The sensor indicates the user is traveling at a faster rate than walking and both feet are off the ground between steps.</summary>
    Running,
    /// <summary>The sensor indicates the user is traveling in a motor vehicle on the ground.</summary>
    InVehicle,
    /// <summary>The sensor indicates the user is riding a bicycle on the ground.</summary>
    Biking,
  }
}
