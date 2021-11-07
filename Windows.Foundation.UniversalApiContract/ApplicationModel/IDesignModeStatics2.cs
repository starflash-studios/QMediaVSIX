// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IDesignModeStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2161082679, 45156, 18520, 190, 200, 62, 186, 34, 53, 117, 53)]
  [ExclusiveTo(typeof (DesignMode))]
  internal interface IDesignModeStatics2
  {
    bool DesignMode2Enabled { get; }
  }
}
