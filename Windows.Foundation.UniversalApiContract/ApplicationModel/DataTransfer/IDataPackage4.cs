﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackage4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(329404104, 37762, 21359, 133, 42, 48, 69, 225, 178, 154, 59)]
  [ExclusiveTo(typeof (DataPackage))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IDataPackage4
  {
    event TypedEventHandler<DataPackage, object> ShareCanceled;
  }
}