// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IDesignModeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DesignMode))]
  [Guid(741905356, 63514, 20090, 184, 87, 118, 168, 8, 135, 225, 133)]
  internal interface IDesignModeStatics
  {
    bool DesignModeEnabled { get; }
  }
}
