// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposurePriorityVideoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ExposurePriorityVideoControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(749879459, 20840, 17009, 158, 165, 71, 98, 26, 152, 163, 82)]
  internal interface IExposurePriorityVideoControl
  {
    bool Supported { get; }

    bool Enabled { get; set; }
  }
}
