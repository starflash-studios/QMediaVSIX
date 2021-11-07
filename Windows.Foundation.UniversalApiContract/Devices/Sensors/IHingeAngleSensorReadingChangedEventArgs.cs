// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IHingeAngleSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(618222987, 64208, 17080, 168, 84, 120, 146, 48, 73, 161, 186)]
  [ExclusiveTo(typeof (HingeAngleSensorReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IHingeAngleSensorReadingChangedEventArgs
  {
    HingeAngleReading Reading { get; }
  }
}
